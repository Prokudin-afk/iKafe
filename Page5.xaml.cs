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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        Entities3 entities;
        public Page5()
        {
            InitializeComponent();
            entities = new Entities3();
            Dg_otchet.ItemsSource = null;
            Dg_otchet.ItemsSource = entities.Otchet11.ToList();
        }
    }
}
