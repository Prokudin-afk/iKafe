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
    /// Логика взаимодействия для Mestaa.xaml
    /// </summary>
    public partial class Mestaa : Page
    {
        Entities3 entities;
        public Mestaa()
        {
            InitializeComponent();
            entities = new Entities3();
            Dg_mesta.ItemsSource = null;
            Dg_mesta.ItemsSource = entities.Mesta.ToList();
        }
        private void Clearb1(object sender, RoutedEventArgs e)
        {                   
                entities = new Entities3();
                Mesta mest = entities.Mesta.Where(x => x.id == 1).FirstOrDefault();
                mest.C09_00_12_00 = 1;
                mest.C12_00_15_00 = 1;
                mest.C15_00_18_00 = 1;
                entities.SaveChanges();
                MessageBox.Show("Таблица очищена");             
        }
        private void Clearb2(object sender, RoutedEventArgs e)
        {                  
                entities = new Entities3();
                Mesta mest = entities.Mesta.Where(x => x.id == 2).FirstOrDefault();
                mest.C09_00_12_00 = 1;
                mest.C12_00_15_00 = 1;
                mest.C15_00_18_00 = 1;
                entities.SaveChanges();
                MessageBox.Show("Таблица очищена");             
        }
        private void Clearb3(object sender, RoutedEventArgs e)
        {
            entities = new Entities3();
            Mesta mest = entities.Mesta.Where(x => x.id == 3).FirstOrDefault();
            mest.C09_00_12_00 = 1;
            mest.C12_00_15_00 = 1;
            mest.C15_00_18_00 = 1;
            entities.SaveChanges();
            MessageBox.Show("Таблица очищена");
        }
        private void Clearb4(object sender, RoutedEventArgs e)
        {
            entities = new Entities3();
            Mesta mest = entities.Mesta.Where(x => x.id == 4).FirstOrDefault();
            mest.C09_00_12_00 = 1;
            mest.C12_00_15_00 = 1;
            mest.C15_00_18_00 = 1;
            entities.SaveChanges();
            MessageBox.Show("Таблица очищена");
        }
        private void Clearb5(object sender, RoutedEventArgs e)
        {
            entities = new Entities3();
            Mesta mest = entities.Mesta.Where(x => x.id == 5).FirstOrDefault();
            mest.C09_00_12_00 = 1;
            mest.C12_00_15_00 = 1;
            mest.C15_00_18_00 = 1;
            entities.SaveChanges();
            MessageBox.Show("Таблица очищена");
        }
    }
}
