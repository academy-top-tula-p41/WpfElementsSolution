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

namespace WpfButtonsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button = new Button();
            button.Content = "Hello world";

            buttonHello.Content = "GoodBy World";
        }

        private void buttonHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wow! Wow! Hello world!");
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Info");
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Ignore Changed");
            this.Close();
        }

        private void rbuttonPlus_Click(object sender, RoutedEventArgs e)
        {
            int value = Int32.Parse(textBoxTablo.Text) + 1;
            textBoxTablo.Text = value.ToString();
        }

        private void rbuttonMinus_Click(object sender, RoutedEventArgs e)
        {
            int value = Int32.Parse(textBoxTablo.Text) - 1;
            textBoxTablo.Text = value.ToString();
        }
    }
}