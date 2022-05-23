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
using System.Collections.ObjectModel;
using System.Windows.Shapes;

namespace Binding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Person> lista_osob = new ObservableCollection<Person>();


        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = lista_osob;
        }
      
        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            double temp_double;
            int temp_int;
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(surnameTextBox.Text) ||
                String.IsNullOrEmpty(ageTextBox.Text) || String.IsNullOrEmpty(weightTextBox.Text))
            {
                MessageBox.Show("Trzeba wpisac dane we wszystkie pola!");
            }
            else if (!Double.TryParse(weightTextBox.Text, out temp_double) || !int.TryParse(ageTextBox.Text, out temp_int))
            {
                MessageBox.Show("Nieprawidlowy format wprowadzonych danych!");
            }
            else
            {
                lista_osob.Add(new Person(nameTextBox.Text, surnameTextBox.Text, temp_int, temp_double));
            }
        }

        private void usunButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Kurwa");
            }
            else
            {
                lista_osob.RemoveAt(listBox.SelectedIndex);
            }
        }
    }
}
