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

namespace PianoProject.Pages.Managers
{
    /// <summary>
    /// Логика взаимодействия для ManagerOrdersPage.xaml
    /// </summary>
    public partial class ManagerOrdersPage : Page
    {
        public ManagerOrdersPage()
        {
            InitializeComponent();
            orderdg.ItemsSource = AppData.db.Orders.ToList();   
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            orderdg.ItemsSource = AppData.db.Orders.ToList();
            MessageBox.Show("Обновлено");
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Window adderOrderWindow = new AdderWindowOrder();
            adderOrderWindow.Show();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var curOrder = orderdg.SelectedItem as Orders;
            AppData.db.Orders.Remove(curOrder);
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditOrderPage());
        }
    }
}
