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
    /// Логика взаимодействия для EditOrderPage.xaml
    /// </summary>
    public partial class EditOrderPage : Page
    {
        public EditOrderPage()
        {
            InitializeComponent();
            orderdg.ItemsSource=AppData.db.Orders;
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = date.SelectedDate.GetValueOrDefault();
            var curOrder = orderdg.SelectedItem as Orders;
            try
            {
                if (!string.IsNullOrEmpty(pianoidbox.Text) && !string.IsNullOrEmpty(useridbox.Text))
                {





                    curOrder.IdPiano = Convert.ToInt32(pianoidbox.Text);
                    curOrder.SaleDate = selectedDate;
                    curOrder.IdUser = Convert.ToInt32(useridbox.Text);



                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");



                }
                else
                {
                    MessageBox.Show("Пусто!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }



        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManagerOrdersPage());    
        }
    }
}
