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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Open1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1());
        }
        private void Open2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page2());
        }
        private void Open3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page3());
        }
        private void Open4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page5());
        }
        private void Open5(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page6());
        }
        private void Open6(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page7());
        }
        private void OpenM(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Mestaa());
        }
    }
}
