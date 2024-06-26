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

namespace PianoProject.Pages.Managers
{
    /// <summary>
    /// Логика взаимодействия для ManagerChooser.xaml
    /// </summary>
    public partial class ManagerChooser : Page
    {
        public ManagerChooser()
        {
            InitializeComponent();
        }

        private void PianoOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManagerPianoPage()); 
        }

        private void OrderOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManagerOrdersPage());
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }
    }
}
