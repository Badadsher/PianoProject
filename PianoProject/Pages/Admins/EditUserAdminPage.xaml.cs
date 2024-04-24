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
    /// Логика взаимодействия для EditUserAdminPage.xaml
    /// </summary>
    public partial class EditUserAdminPage : Page
    {
        int result;
        public EditUserAdminPage()
        {
            InitializeComponent();
            UsersGrid.ItemsSource = AppData.db.Users.ToList();  
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            var curUser = UsersGrid.SelectedItem as Users;
            try
            {
                if (!string.IsNullOrEmpty(loginbox.Text) && !string.IsNullOrEmpty(idrolebox.Text) && !string.IsNullOrEmpty(passbox.Text) && !string.IsNullOrEmpty(emailbox.Text) && !string.IsNullOrEmpty(phonebox.Text) )
                {
                    string input = idrolebox.Text;
                    bool isInt = int.TryParse(input, out result);
                    if (isInt)
                    {

                        curUser.Login = loginbox.Text.ToLower();
                        curUser.Password = passbox.Text.ToLower();
                        curUser.Email = emailbox.Text;
                        curUser.PhoneNumber = Convert.ToInt32(phonebox.Text);
                        curUser.IdRole = Convert.ToInt32(idrolebox.Text);
                      
             
                        AppData.db.SaveChanges();
                        MessageBox.Show("Изменения внесены!");
                    }
                    else
                    {
                        MessageBox.Show("Введите в окно ввода роли цифру роли!");
                    }

                }
                else
                {
                    MessageBox.Show("Пусто!");
                }
            }
        }
    }
}
