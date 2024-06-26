﻿using PianoProject.Model;
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

namespace PianoProject.Pages.Managers
{
    /// <summary>
    /// Логика взаимодействия для ManagerPianoPage.xaml
    /// </summary>
    public partial class ManagerPianoPage : Page
    {
        public ManagerPianoPage()
        {
            InitializeComponent();
           
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPianoPage());
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                var curPiano = pianodg.SelectedItem as Piano;
                AppData.db.Piano.Remove(curPiano);
                MessageBox.Show("Успешно");
                AppData.db.SaveChanges();
            }
        catch(Exception ex) { 
                MessageBox.Show(ex.Message);}
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            pianodg.ItemsSource = AppData.db.Piano.ToList();
            MessageBox.Show("Обновлено");

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Window adderPianoWindow = new AdderWindowPiano();
            adderPianoWindow.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManagerChooser());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pianodg.Items.Clear();
            pianodg.ItemsSource = AppData.db.Piano.ToList();
        }

        private void Search_Tbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string searchQuery = Search_Tbox.Text.Trim();

                if (string.IsNullOrEmpty(searchQuery))
                {
                    pianodg.ItemsSource = AppData.db.Piano.ToList();
                }
                else
                {

                    pianodg.ItemsSource = AppData.db.Piano.Where(piano => piano.Model.Contains(searchQuery)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
