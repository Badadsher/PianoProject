using PianoProject.Model;
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
            pianodg.ItemsSource = AppData.db.Piano.ToList();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPianoPage());
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var curPiano = pianodg.SelectedItem as Piano;
            AppData.db.Piano.Remove(curPiano);
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
    }
}
