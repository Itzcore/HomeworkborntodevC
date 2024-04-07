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

namespace Buysomething
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double i = Convert.ToDouble(income.Text);
            double o = Convert.ToDouble(outcome.Text);
            double h = Convert.ToDouble(hope.Text);

            double u = (i - o);
            double re = (h / u);
            result.Text = re.ToString();

        }

        private void income_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void outcome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void hope_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}