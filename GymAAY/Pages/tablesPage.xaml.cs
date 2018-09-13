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
using System.Windows.Shapes;

namespace GymAAY.Pages
{
    /// <summary>
    /// Interaction logic for tablesPage.xaml
    /// </summary>
    public partial class tablesPage : Page
    {
        public tablesPage()
        {
            InitializeComponent();
            if (var.tv_on == true)
            {
                image3.Visibility = Visibility.Visible;
                button9.Visibility = Visibility.Visible;
                button10.Visibility = Visibility.Collapsed;
            } else
            {
                image3.Visibility = Visibility.Collapsed;
                button9.Visibility = Visibility.Collapsed;
                button10.Visibility = Visibility.Visible;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            elevatorPage elvp = new elevatorPage();
            this.NavigationService.Navigate(elvp);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            image.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Visible;
            buy();


        }

        void buy()
        {
            textBlock.Text = "Θα πληρώσετε μετρητά " + Environment.NewLine + "ή να τα βάλουμε στο λογ/μο σας;";
            button4.Content = "Μετρητά";
            button6.Content = "Στο λογαριασμό μου";
            button4.Click += pay_cash;
            button6.Click += go_back;
        }


        void pay_cash(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Μη ξεχάσετε τα ρέστα σας";
            button4.Visibility = Visibility.Collapsed;
            button6.Content = "Ευχαριστώ πολύ";
        }
        void go_back(object sender, RoutedEventArgs e)
        {
            tablesPage tables = new tablesPage();
            this.NavigationService.Navigate(tables);
        }

 

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            image.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Visible;
            buy();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button9.Visibility = Visibility.Collapsed;
            button10.Visibility = Visibility.Visible;
            image3.Visibility = Visibility.Collapsed;
            var.tv_on = false;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            button9.Visibility = Visibility.Visible;
            button10.Visibility = Visibility.Collapsed;
            image3.Visibility = Visibility.Visible;
            var.tv_on = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GymAAY μια εφαρμογή των Γεωργούλη Αριστοτέλη και Σανιδά Γεώργιου");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Help.chm");

        }
    }
}
