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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            if (!string.IsNullOrWhiteSpace(Fname.Text))
            {
                client.FirstName = Fname.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }
            if (!string.IsNullOrWhiteSpace(Lname.Text))
            {
                client.LastName = Lname.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели фамилию");
                return;
            }
            if (!string.IsNullOrWhiteSpace(Phone.Text))
            {
                client.Phone = Phone.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели номер");
                return;
            }

            MessageBox.Show("Пользователь добавлен");
            context.Client.Add(client);
            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
            this.Close();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
            this.Close();
        }
        private void Fname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Lname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Phone_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
