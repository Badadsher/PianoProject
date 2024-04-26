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

namespace PianoProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegIn.xaml
    /// </summary>
    public partial class RegIn : Page
    {
        public RegIn()
        {
            InitializeComponent();
        }

        public void RegInBtn_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if ( !string.IsNullOrEmpty(TxbLogin.Text) && !string.IsNullOrEmpty(TxbEmail.Text)
               && !string.IsNullOrEmpty(TxbNumber.Text) && !string.IsNullOrEmpty(TxbPassword.Password) &&
               !string.IsNullOrEmpty(TxbRePassword.Password) && TxbRePassword.Password == TxbPassword.Password)
            {
                Users people = new Users();

                people.ID = AppData.db.Users.Any() ? AppData.db.Users.Max(u => u.ID) + 1 : 1;
                people.Login = TxbLogin.Text;
                people.Email = TxbEmail.Text;
                people.PhoneNumber = (int)Convert.ToInt64(TxbNumber.Text);
                people.Password = TxbPassword.Password;
                people.IdRole = 3;

                AppData.db.Users.Add(people);
                AppData.db.SaveChanges();
                MessageBox.Show("Пользователь успешно был добавлен в базу");
            }
            else
            {
                MessageBox.Show("Ошибка, некоторые поля пустые", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error) ;
            }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }
    }
}
