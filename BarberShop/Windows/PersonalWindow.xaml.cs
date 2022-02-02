using BarberShop.EF;
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
using static BarberShop.ClassEntities;
using BarberShop.EF;

namespace BarberShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для PersonalWindow.xaml
    /// </summary>
    public partial class PersonalWindow : Window
    {
        List<Personnel> personnels = new List<Personnel>();
        public PersonalWindow()
        {
            InitializeComponent();
            personnels = context.Personnel.ToList();

            AllPersonal.ItemsSource = personnels;
            Filter();
        }
        private void Filter()
        {
            personnels = ClassEntities.context.Personnel.ToList();
            personnels = personnels.Where(i => i.INFO.Contains(Search.Text)).ToList();
            AllPersonal.ItemsSource = personnels;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            this.Close();
        }
    }
}
