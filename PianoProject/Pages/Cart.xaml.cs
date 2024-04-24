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

namespace PianoProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();

            //using (var context = new PianooEntities())
            //{
            //    var query = from idTableControl in context.ControlTable
            //                join idNameTableBook in context.Books
            //                on idTableControl.IDBook equals idNameTableBook.ID
            //                join idAbonent in context.Abonent
            //                on idTableControl.IDAbonent
            //                equals idAbonent.ID
            //                select new
            //                {
            //                    Id = idTableControl.IDBook,
            //                    BookName = idNameTableBook.Title,
            //                    IDAbonent = idTableControl.IDAbonent,

            //                };


            //    usersGrid.ItemsSource = query.Where(item => item.IDAbonent == Saver.SaveLog).ToList();
            //}

            orderdg.ItemsSource = AppData.db.cart.ToList();

            using (var context = new PianooEntities())
            {
                var data = context.Orders.Where(e => e.IdUser == Saver.SaveLog).ToList();

        
                orderdg.ItemsSource = data;
            }
        }

        private void BuyBT(object sender, RoutedEventArgs e)
        {
            var curPiano = orderdg.SelectedItem as cart;
            AppData.db.cart.Remove(curPiano);
        }
    }
}
