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
        public MainWindow()
        {
            InitializeComponent();

            //listBoxEmployees.ItemsSource = names;
            //foreach (var name in names)
            //    listBoxEmployees.Items.Add(name);

            listBoxEmployees.ItemsSource = employees;
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
    }
}