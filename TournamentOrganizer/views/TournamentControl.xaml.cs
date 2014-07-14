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

namespace TournamentOrganizer.views
{
    /// <summary>
    /// Interaction logic for TournamentControl.xaml
    /// </summary>
    public partial class TournamentControl : UserControl
    {
        public TournamentControl(Tournament tournament)
        {
            this.DataContext = tournament;
            InitializeComponent();
        }

        private Tournament GetDataContext() {
            return (Tournament)this.DataContext;
        }

        private void NewPlayer_Click(object sender, RoutedEventArgs e)
        {
            Team newTeam = new Team();
            Player player = new Player();
            newTeam.addPlayer(player);
            GetDataContext().addTeam(newTeam);
        }
    }
}
