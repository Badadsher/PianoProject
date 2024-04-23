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

namespace PianoProject.Pages.Admins
{
    /// <summary>
    /// Логика взаимодействия для AdminUserPage.xaml
    /// </summary>
    public partial class AdminUserPage : Page
    {
        public AdminUserPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsersGrid.Items.Clear();
            UsersGrid.ItemsSource = AppData.db.Users.ToList();
        }

        private void Search_Tbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string searchQuery = Search_Tbox.Text.Trim();

                if (string.IsNullOrEmpty(searchQuery))
                {
                    UsersGrid.ItemsSource = AppData.db.Users.ToList();
                }
                else
                {

                    UsersGrid.ItemsSource = AppData.db.Users.Where(user => user.Login.Contains(searchQuery)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdderUserWindow());
        }
    }
}
