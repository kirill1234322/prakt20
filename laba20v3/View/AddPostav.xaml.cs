using laba20v3.Models;
using laba20v3.ViewModels;
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
    /// Логика взаимодействия для AddPostav.xaml
    /// </summary>
    public partial class AddPostav : Window
    {
        laba19_20Entities laba1920 = new laba19_20Entities();


        public AddPostav()
        {
            InitializeComponent();
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Postav customer = new Postav
            {
                Name = name.Text,
               
            };

            // Добавить в DbSet
            laba1920.Postav.Add(customer);

            // Сохранить изменения в базе данных
            laba1920.SaveChanges();
            MessageBox.Show("Позиция добавлена");
            Close();
        }
    }
}
