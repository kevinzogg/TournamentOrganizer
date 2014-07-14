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
using TournamentOrganizer.domain;
using TournamentOrganizer.views;

namespace TournamentOrganizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewTournament(object sender, RoutedEventArgs e)
        {
            Tournament tournament = new Tournament();
            TournamentControl tournamentControl = new TournamentControl(tournament);
            this.ContentArea.Children.Add(tournamentControl);
            this.ContentArea.UpdateLayout();
        }
    }
}
