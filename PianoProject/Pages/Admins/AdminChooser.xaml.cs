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

namespace PianoProject.Pages.Admins
{
    /// <summary>
    /// Логика взаимодействия для AdminChooser.xaml
    /// </summary>
    public partial class AdminChooser : Page
    {
        public AdminChooser()
        {
            InitializeComponent();
        }

        private void ChooserBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminUserPage());
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }
    }
}
