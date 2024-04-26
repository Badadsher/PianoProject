using PianoProject.Model;
using PianoProject.Pages.Admins;
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
using PianoProject.Pages.Managers;

namespace PianoProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }


        private int failedAttempts = 0;
      
        public void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentUser = AppData.db.Users.FirstOrDefault(u => u.Login == TxbLogin.Text && u.Password == TxbPassword.Password);

                if (CurrentUser != null && CurrentUser.IdRole == 1)
                {
                    Saver.SaveLog = CurrentUser.ID;
                    NavigationService.Navigate(new AdminChooser());
                }
                else if (CurrentUser != null && CurrentUser.IdRole == 2)
                {
                    Saver.SaveLog = CurrentUser.ID;
                    Saver.SaveLog = 1;
                    NavigationService.Navigate(new ManagerChooser());
                }
                else if (CurrentUser != null && CurrentUser.IdRole == 3)
                {
                    Saver.SaveLog = CurrentUser.ID;
                    Saver.SaveLog = 1;
                    NavigationService.Navigate(new Catalog());
                }
                else if (CurrentUser != null && CurrentUser.IdRole == 4)
                {
                    MessageBox.Show("Данный пользователь удален.");
                }
                else
                {
                    failedAttempts++;

                    if (failedAttempts >= 3)
                    {
                        NavigationService.Navigate(new Capcha());
                    }
                    else
                    {
                        MessageBox.Show("Данного пользователя нет в базе. Попробуйте снова.");
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void RegInBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegIn());
        }
    }
}
