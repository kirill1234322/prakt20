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
    /// Логика взаимодействия для nomen1.xaml
    /// </summary>
    public partial class nomen1 : Window
    {
        laba19_20Entities laba1920 = new laba19_20Entities();
        public nomen1()
        {
            InitializeComponent();
            DataContext = new VIewModel();
            FillNom();
        }
        private void FillNom()
        {
            ((VIewModel)DataContext).OutputNom();
        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Удалить позицию?", "Удаление",
       MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                int id = (datagridnom.SelectedItem as nom).ID;
                nom nom = (from r in laba1920.nom where r.ID == id select r).SingleOrDefault();
                laba1920.nom.Remove(nom);
                laba1920.SaveChanges();
                datagridnom.ItemsSource = laba1920.nom.ToList();

                var row = datagridnom.SelectedItem as DataRowView;
                if (row == null)
                    return;
                //удаляем
                row.Delete();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNomen addPostav = new AddNomen();
            addPostav.ShowDialog();
        }
    }
}
