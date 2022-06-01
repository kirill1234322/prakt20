using laba20v3.Models;
using laba20v3.View;
using laba20v3.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для postav1.xaml
    /// </summary>
    public partial class postav1 : Window
    {
        laba19_20Entities laba1920 = new laba19_20Entities();
        private VIewModel postlist;

        public postav1()
        {
            InitializeComponent();
            DataContext = new VIewModel();
            FillPostav();
        }
        private void FillPostav()
        {
            ((VIewModel)DataContext).OutputPostav();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPostav addPostav = new AddPostav();
            addPostav.ShowDialog();
        }



        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Удалить позицию?", "Удаление",
       MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                int id = (datagridpost.SelectedItem as Postav).ID;
                Postav postav = (from r in laba1920.Postav where r.ID == id select r).SingleOrDefault();
                laba1920.Postav.Remove(postav);
                laba1920.SaveChanges();
                datagridpost.ItemsSource = laba1920.Postav.ToList();

                var row = datagridpost.SelectedItem as DataRowView;
                if (row == null)
                    return;
                //удаляем
                row.Delete();

            }
        }
      
        private void Update(object sender, RoutedEventArgs e)
        {
            
           
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void datagridpost_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            if (datagridpost.SelectedItems.Count == 0) return;
           var clientName = ((DataRowView)datagridpost.SelectedItems[0]).Row["Name"].ToString();
           var clientID = (int)((DataRowView)datagridpost.SelectedItems[0]).Row["ID"];
            MessageBox.Show(""+clientName+clientID);

        }

        
    }
}
