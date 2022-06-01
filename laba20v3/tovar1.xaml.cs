using laba20v3.Models;
using laba20v3.ViewModels;
using laba20v3.View;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для tovar1.xaml
    /// </summary>
    public partial class tovar1 : Window
    {
       public static laba19_20Entities laba1920 { get; set; }
        public tovar1()
        {
            laba1920 = new laba19_20Entities();
            InitializeComponent();
            DataContext = new VIewModel();
            FillTovar();
        }
        private void FillTovar()
        {
            ((VIewModel)DataContext).OutputTov();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTovar addTovar = new AddTovar();
            addTovar.ShowDialog();
        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Удалить позицию?", "Удаление",
       MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                int id = (datagridtov.SelectedItem as tov).ID;
                tov tov = (from r in laba1920.tov where r.ID == id select r).SingleOrDefault();
                laba1920.tov.Remove(tov);
                laba1920.SaveChanges();
                datagridtov.ItemsSource = laba1920.tov.ToList();

                var row = datagridtov.SelectedItem as DataRowView;
                if (row == null)
                    return;
                //удаляем
                row.Delete();

            }
        }
    }
}
