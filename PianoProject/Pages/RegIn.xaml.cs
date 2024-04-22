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

        private void LogInNavigate(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }

        private void RegInClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
