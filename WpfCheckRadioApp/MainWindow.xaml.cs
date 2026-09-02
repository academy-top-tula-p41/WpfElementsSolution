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

namespace WpfCheckRadioApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Checked");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Unchecked");
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Indeterminate");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textBlockCity.Text = (sender as RadioButton)?.Content.ToString();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            textBlockLang.Text = (sender as RadioButton)?.Content.ToString();
        }
    }
}