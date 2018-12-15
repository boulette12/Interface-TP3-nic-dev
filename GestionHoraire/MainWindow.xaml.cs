using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionHoraire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rdbDate.IsChecked = true;
        }

        private void rdbDate_Checked(object sender, RoutedEventArgs e)
        {
            cld1.Visibility = Visibility.Visible;
            stkHeure.Visibility = Visibility.Visible;
            stkTypelocal.Visibility = Visibility.Collapsed;
        }

        private void rdbType_Checked(object sender, RoutedEventArgs e)
        {
            cld1.Visibility = Visibility.Collapsed;
            stkHeure.Visibility = Visibility.Collapsed;
            stkTypelocal.Visibility = Visibility.Visible;
        }

        private void aide_Click(object sender, RoutedEventArgs e)
        {
            Aide fen = new Aide();
            fen.ShowDialog();
        }

        private void mniQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
