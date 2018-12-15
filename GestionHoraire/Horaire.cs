using System;

namespace GestionHoraire
{
    public enum JourDeLaSemaine
    {
        Lundi    = 1,
        Mardi    = 2,
        Mercredi = 3,
        Jeudi    = 4,
        Vendredi = 5,
        Samedi   = 6,
        Dimanche = 7
    }

    public class Horaire
    {
        public string NoGroupe { get; set; }
        public string NomCours { get; set; }
        public string NoCours { get; set; }
        public string NoLocal { get; set; }
        public string IDLocal { get; set; }
        public string TypeLocal { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public JourDeLaSemaine Jour { get; set; }

        public Horaire() { }

        public Horaire(string numGroupe, string numCours, string nomCours,
                       string numLocal, string idLocal, string typeLocal,
                       DateTime dateDebut, DateTime dateFin,
                       JourDeLaSemaine jour)
        {
            this.Jour = jour;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.NoGroupe = numGroupe;
            this.NoCours = numCours;
            this.NomCours = nomCours;
            this.NoLocal = numLocal;
            this.IDLocal = idLocal;
            this.TypeLocal = typeLocal;
        }

        public Horaire(string numGroupe, string numCours, string nomCours, string numLocal, 
                       string idLocal, string typeLocal, string dateDebut, string heureDebut, 
                       string dateFin, string heureFin, string numJour)
        {
            this.DateDebut = DateTime.Parse($"{dateDebut}T{heureDebut}");
            this.DateFin = DateTime.Parse($"{dateFin}T{heureFin}");
            this.Jour = (JourDeLaSemaine)int.Parse(numJour);
            this.NoGroupe = numGroupe;
            this.NoCours = numCours;
            this.NomCours = nomCours;
            this.NoLocal = numLocal;
            this.IDLocal = idLocal;
            this.TypeLocal = typeLocal;
        }
    }
}
