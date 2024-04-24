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
    /// Логика взаимодействия для EditPianoPage.xaml
    /// </summary>
    public partial class EditPianoPage : Page
    {
        public EditPianoPage()
        {
            InitializeComponent();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            var curPiano = pianodg.SelectedItem as Piano;
            try
            {
                if (!string.IsNullOrEmpty(pricebox.Text) && !string.IsNullOrEmpty(modelbox.Text) && !string.IsNullOrEmpty(countbox.Text)) {


                  
                    

                        curPiano.Price = Convert.ToInt32(pricebox.Text);
                        curPiano.Model = modelbox.Text;
                        curPiano.Count = Convert.ToInt32(countbox.Text);
                       


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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pianodg.ItemsSource = AppData.db.Piano.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManagerPianoPage()); 
        }
    }
}
