using laba20v3.Models;
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

namespace laba20v3
{
    /// <summary>
    /// Логика взаимодействия для AddTovar.xaml
    /// </summary>
    public partial class AddTovar : Window
    {
        laba19_20Entities laba1920 = new laba19_20Entities();
        public AddTovar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = cmb.SelectedItem as nom;
                tov customer = new tov
                {
                    demensions = name0.Text,
                    composition = name1.Text,
                    price1 = Convert.ToInt32(name2.Text),
                    price2 = Convert.ToInt32(name3.Text),
                    price3 = Convert.ToInt32(name4.Text),
                    box = name5.Text,
                    price4 = Convert.ToInt32(name6.Text),
                    description = name7.Text,
                    id_nom = client.ID

                };
                
                // Добавить в DbSet
                laba1920.tov.Add(customer);

                // Сохранить изменения в базе данных
                laba1920.SaveChanges();
                MessageBox.Show("Позиция добавлена");
                Close();
            }
            catch
            {
                
                MessageBox.Show("Не все поля заполнены");
            }
            
        }
    }
}
