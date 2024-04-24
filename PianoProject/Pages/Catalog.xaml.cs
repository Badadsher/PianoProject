using PianoProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
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
using static System.Net.Mime.MediaTypeNames;

namespace PianoProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
            var currentPianos = AppData.db.Piano.ToList();
            dg.ItemsSource = AppData.db.Piano.ToList();
          
        }

        private void CartClick(object sender, RoutedEventArgs e)
        {
            Window cartwind = new Cart();
            cartwind.Show();
        }

        private void BuyBTN(object sender, RoutedEventArgs e)
        {
            var curPiano = dg.SelectedItem as Piano;
            curPiano.Count --;
            
            cart carton = new cart();
            carton.IDCart = AppData.db.cart.Any() ? AppData.db.cart.Max(u => u.IDCart) + 1 : 1;
            carton.PianoID = curPiano.IDPianino;
            carton.IDUser = Saver.SaveLog;

            AppData.db.cart.Add(carton);
            AppData.db.SaveChanges();
        }
    }
}
