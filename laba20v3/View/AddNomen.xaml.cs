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
    /// Логика взаимодействия для AddNomen.xaml
    /// </summary>
    public partial class AddNomen : Window
    {
        laba19_20Entities laba1920 = new laba19_20Entities();
        public AddNomen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nom customer = new nom
            {
                Name = name.Text,

            };

            // Добавить в DbSet
            laba1920.nom.Add(customer);

            // Сохранить изменения в базе данных
            laba1920.SaveChanges();
            MessageBox.Show("Позиция добавлена");
            Close();
        }
    }
}
