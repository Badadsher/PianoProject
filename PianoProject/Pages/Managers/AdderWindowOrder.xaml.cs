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

namespace PianoProject.Pages.Managers
{
    /// <summary>
    /// Логика взаимодействия для AdderWindowOrder.xaml
    /// </summary>
    public partial class AdderWindowOrder : Window
    {
        public AdderWindowOrder()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = date.SelectedDate.GetValueOrDefault();

            try
            {
                if (!string.IsNullOrEmpty(pianoidbox.Text) && !string.IsNullOrEmpty(useridbox.Text))
                {
                    Orders order = new Orders();
                    order.IDOrder = AppData.db.Orders.Any() ? AppData.db.Orders.Max(u => u.IDOrder) + 1 : 1;
                    order.IdPiano = Convert.ToInt32(pianoidbox.Text);
                    order.IdUser = Convert.ToInt32(useridbox.Text);
                    order.SaleDate = selectedDate;
                    AppData.db.Orders.Add(order);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Заказ успешно был добавлен в базу");
                    this.Close();
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
