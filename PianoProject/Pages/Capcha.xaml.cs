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
    /// Логика взаимодействия для Capcha.xaml
    /// </summary>
    public partial class Capcha : Page
    {
        Random random = new Random();
        public Capcha()
        {
            InitializeComponent();
            GenerateCapcha();
        }

        private void GenerateCapcha()
        {


            capchaText.Text = random.Next(1000, 9999).ToString();
        }

        public void verifyCapcha_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (inputCapcha.Text == capchaText.Text)
                {
                    NavigationService.Navigate(new Login());
                    MessageBox.Show("Успешно!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                    capchaText.Text = random.Next(1000, 9999).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}