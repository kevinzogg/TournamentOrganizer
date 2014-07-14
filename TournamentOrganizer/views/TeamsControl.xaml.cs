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
using TournamentOrganizer.services;

namespace TournamentOrganizer.views
{
    /// <summary>
    /// Interaction logic for TeamsControl.xaml
    /// </summary>
    public partial class TeamsControl : UserControl
    {
        private TeamManagement teamManagement = new TeamManagement();

        public TeamsControl()
        {
            InitializeComponent();
        }

        private Tournament GetDataContext()
        {
            return (Tournament)this.DataContext;
        }

        private void CreateRandomTeams(object sender, RoutedEventArgs e)
        {
            IList<Team> teams = teamManagement.CreateRandomTeams(GetDataContext().Players);
            foreach (Team team in teams) {
                GetDataContext().AddTeam(team);
            }
        }
    }
}
