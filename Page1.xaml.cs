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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Entities3 entities;
        
        public Page1()
        {
            InitializeComponent();

            entities = new Entities3();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Otchet11 name1 = new Otchet11();
                name1.name = tbx_name.Text;
                name1.surname = tbx_surname.Text;
                name1.phone = tbx_phone.Text;
                name1.idMesta = int.Parse(cb_mesto.SelectedIndex.ToString()) + 1;
                name1.datetimeofzakaz = DateTime.Now;
                entities.Otchet11.Add(name1);
                Mesta mest = entities.Mesta.Where(x => x.id == cb_mesto.SelectedIndex + 1).FirstOrDefault();
                mest.C09_00_12_00 = 0;
                entities.SaveChanges();
                MessageBox.Show("Место забронировано");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }


        }
    }
}
