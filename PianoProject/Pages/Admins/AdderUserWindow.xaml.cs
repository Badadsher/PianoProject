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
using System.Windows.Shapes;

namespace PianoProject.Pages.Admins
{
    /// <summary>
    /// Логика взаимодействия для AdderUserWindow.xaml
    /// </summary>
    public partial class AdderUserWindow : Window
    {
        public AdderUserWindow()
        {
            InitializeComponent();

            CmbRole.ItemsSource = AppData.db.Roles.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxbLogin.Text) && !string.IsNullOrEmpty(TxbEmail.Text)
               && !string.IsNullOrEmpty(TxbNumber.Text) && !string.IsNullOrEmpty(TxbPassword.Text)
               && CmbRole.SelectedItem != null)
                {
                    Users people = new Users();

                    people.ID = AppData.db.Users.Any() ? AppData.db.Users.Max(u => u.ID) + 1 : 1;
                    people.Email = TxbEmail.Text;
                    people.Login = TxbLogin.Text;
                    people.Password = TxbPassword.Text;
                    people.PhoneNumber = Convert.ToInt32(TxbNumber.Text);

                    var CurrentRole = CmbRole.SelectedItem as Roles;
                    ;
                    people.IdRole = CurrentRole.ID;


                    AppData.db.Users.Add(people);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Пользователь успешно был добавлен в базу");
                }
                else
                {
                    MessageBox.Show("Ошибка, некоторые поля пустые", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
