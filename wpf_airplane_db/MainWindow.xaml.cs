using EntityFramerworkCorePD_211;
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

namespace wpf_airplane_db
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirplaneDbContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new AirplaneDbContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Flights.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Airplanes.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = context.Clients.ToList();
        }
    }
}