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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            Gender.ItemsSource = context.Gender.ToList();
            Gender.DisplayMemberPath = "GenderName";
            Gender.SelectedIndex = 0;

            Pecialization.ItemsSource = context.Specialization.ToList();
            Pecialization.DisplayMemberPath = "SpecializationName";
            Pecialization.SelectedIndex = 0;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Personnel personnel = new Personnel();
            if (!string.IsNullOrWhiteSpace(Fname.Text))
            {
                personnel.FirstName = Fname.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }
            if (!string.IsNullOrWhiteSpace(Lname.Text))
            {
                personnel.LastName = Lname.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели фамилию");
                return;
            }
            if (!string.IsNullOrWhiteSpace(Phone.Text))
            {
                personnel.Phone = Phone.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели номер");
                return;
            }
            if (!string.IsNullOrWhiteSpace(NumberPas.Text))
            {
                personnel.PassportNumber = NumberPas.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели номер пасспорта");
                return;
            }
            if (!string.IsNullOrWhiteSpace(SeriaPas.Text))
            {
                personnel.Passport_Series = SeriaPas.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели серию пасспорта");
                return;
            }
            if (!string.IsNullOrWhiteSpace(Experience.Text))
            {
                personnel.Experience = Convert.ToInt32(Experience.Text);
            }
            else
            {
                MessageBox.Show("Вы не ввели стаж");
                return;
            }
            personnel.IdGender = Gender.SelectedIndex + 1;
            personnel.IdSpecialization = Pecialization.SelectedIndex + 1;

            MessageBox.Show("Пользователь добавлен");
            context.Personnel.Add(personnel);
            context.SaveChanges();
 
            this.Hide();
            PersonalWindow personalWindow = new PersonalWindow();
            personalWindow.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PersonalWindow personalWindow = new PersonalWindow();
            personalWindow.ShowDialog();
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

        private void NumberPas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void SeriaPas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Experience_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
