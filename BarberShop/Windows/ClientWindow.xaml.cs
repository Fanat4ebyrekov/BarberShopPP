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

namespace BarberShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        List<Client> client = new List<Client>();

        public ClientWindow()
        {
            InitializeComponent();
            AllClient.ItemsSource = context.Client.ToList();
            Filter();
        }
        private void Filter()
        {
            client = ClassEntities.context.Client.ToList();
            client = client.Where(i => i.FIO.Contains(Search.Text)).ToList();
            AllClient.ItemsSource = client;

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
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.ShowDialog();
            this.Close();
        }
    }
}
