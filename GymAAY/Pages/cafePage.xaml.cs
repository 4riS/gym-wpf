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
    /// Interaction logic for cafePage.xaml
    /// </summary>
    public partial class cafePage : Page
    {
        public cafePage()
        {
            InitializeComponent();
            var.get_hour();
            check_hour();
            if (controlPage.employee)
            {
                textBlock.Text = "Θα βγούμε το βράδυ;";
                button4.Content = "Ασε με τωρα, πεινάω";
                button5.Content = "Κάτι ξέχασα";
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
            cafeMenuPage cfm = new cafeMenuPage();
            this.NavigationService.Navigate(cfm);
        }

        private void check_hour()
        {

            if (var.night)
            {
                textBlock.Text = "Λυπούμαστε, το καφέ έχει κλείσει";
                button4.Visibility = Visibility.Collapsed;
                button5.Content = "Επιστροφή στο ασανσέρ";

            }

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
