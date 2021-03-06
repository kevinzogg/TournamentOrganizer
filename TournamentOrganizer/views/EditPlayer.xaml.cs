﻿using System;
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
    /// Interaction logic for PlayerAdd.xaml
    /// </summary>
    public partial class EditPlayer : UserControl
    {
        public EditPlayer()
        {
            InitializeComponent();
        }

        void setModel(Player player)
        {
            this.DataContext = player;
        }

        private Player getModel()
        {
            return (Player)this.DataContext;
        }

        private void RemovePlayer(object sender, RoutedEventArgs e)
        {
            getModel().Dispose();
        }
    }
}
