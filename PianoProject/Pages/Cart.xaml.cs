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

          
        }

        private void BuyBT(object sender, RoutedEventArgs e)
        {
            try
            {
                var curCart = cartdg.SelectedItem as cart;
     
                if (curCart != null)
                {
                    AppData.db.cart.Remove(curCart);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Успешно");
               
                    



                    Orders order = new Orders();

                    order.IDOrder = AppData.db.Orders.Any() ? AppData.db.Orders.Max(u => u.IDOrder) + 1 : 1;
                    order.IdUser = Saver.SaveLog;
                    order.IdPiano = curCart.PianoID;
                 order.SaleDate = DateTime.Now;

                    AppData.db.Orders.Add(order);
                    AppData.db.SaveChanges();
               

                    Refresh();








                }
                else
                {
                  ;
                    MessageBox.Show("Выберите элемент для покупки");
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh()
        {
            cartdg.ItemsSource = AppData.db.cart.Where(es => es.IDUser == Saver.SaveLog).ToList(); ;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new PianooEntities())
            {
               
                cartdg.ItemsSource = AppData.db.cart.Where(es => es.IDUser == Saver.SaveLog).ToList(); ;
            }
        }
    }
}