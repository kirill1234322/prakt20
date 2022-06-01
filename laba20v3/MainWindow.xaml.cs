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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba20v3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VIewModel VIewModel { get; } = new VIewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = VIewModel;
        }
        private void post1(object sender, RoutedEventArgs e)
        {
           postav1 postav1 = new postav1();
            postav1.ShowDialog();
        }

        private void nomen1(object sender, RoutedEventArgs e)
        {
            nomen1 nomen1 = new nomen1();
            nomen1.ShowDialog();
        }

        private void tovar1(object sender, RoutedEventArgs e)
        {
            tovar1 tovar1 = new tovar1();
            tovar1.ShowDialog();
        }
    }
}
