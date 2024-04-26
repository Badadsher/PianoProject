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
    /// Логика взаимодействия для AdderWindowPiano.xaml
    /// </summary>
    public partial class AdderWindowPiano : Window
    {
        public AdderWindowPiano()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(countbox.Text) && !string.IsNullOrEmpty(modelbox.Text)
               && !string.IsNullOrEmpty(pricebox.Text))
                {
                    Piano piano = new Piano();

                    piano.IDPianino = AppData.db.Piano.Any() ? AppData.db.Piano.Max(u => u.IDPianino) + 1 : 1;
                    piano.Count = Convert.ToInt32(countbox.Text);
                    piano.Model = modelbox.Text;
                    piano.Price = Convert.ToInt32(pricebox.Text);
                   


                    AppData.db.Piano.Add(piano);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Пианино успешно было добавлен в базу");
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
