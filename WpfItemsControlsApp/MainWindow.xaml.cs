using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfItemsControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> names = new() { "Jimmy", "Bobby", "Sammy" };
        List<Employee> employees = new()
        {
            new(){ Name = "Kenny", Age = 26 },
            new(){ Name = "Lenny", Age = 31 },
            new(){ Name = "Mikky", Age = 28 },
        };

        List<string> countries = new() { "Russia", "German", "China", "Usa", "Japan", "Romania" };

        List<Product> products = new()
        {
            new(){ Title = "iPhone 13", Brand = "Apple", Price = 70000 },
            new(){ Title = "Galaxy Edge", Brand = "Samsung", Price = 50000 },
            new(){ Title = "Lumia 1000", Brand = "Microsoft", Price = 35000 },
        };

        bool asc = false;

        public MainWindow()
        {
            InitializeComponent();

            //listBoxEmployees.ItemsSource = names;
            //foreach (var name in names)
            //    listBoxEmployees.Items.Add(name);

            listBoxEmployees.ItemsSource = employees;
            comboBoxCountries.ItemsSource = countries;
            listViewProducts.ItemsSource = products.OrderBy(p => p.Title);
            dataGridProducts.ItemsSource = products;
        }

        private void buttonAddTommy_Click(object sender, RoutedEventArgs e)
        {
            //listBoxEmployees.Items.Add("Tommy");
            employees.Add(new() { Name = "Tommy", Age = 33 });
            listBoxEmployees.Items.Refresh();
        }

        private void listBoxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //textBlockName.Text = listBoxEmployees.SelectedItem.ToString();

            string names = "";
            foreach(Employee emp in listBoxEmployees.SelectedItems)
                names += emp.Name + " ";
            textBlockName.Text = names;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            if(asc)
                products = products.OrderBy(p => p.Title).ToList();
            else
                products = products.OrderByDescending(p => p.Title).ToList();
            asc = !asc;
            listViewProducts.ItemsSource= products;
        }
    }
}