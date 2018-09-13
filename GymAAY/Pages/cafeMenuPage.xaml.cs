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
    /// Interaction logic for cafeMenuPage.xaml
    /// </summary>
    public partial class cafeMenuPage : Page
    {
        public cafeMenuPage()
        {
            InitializeComponent();
            show_menu();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (var.morning || var.afternoon)
            {
                bar bar = new bar();
                this.NavigationService.Navigate(bar);
            }
            else
            {
                tablesPage tables = new tablesPage();
                this.NavigationService.Navigate(tables);

            }

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            elevatorPage elvp = new elevatorPage();
            this.NavigationService.Navigate(elvp);
        }

        private void show_menu()
        {
         
            if(var.morning)
            {
                textBlock.Text = "Αυτή την ώρα θα σας προτείναμε" + Environment.NewLine + "μια μπάρα δημητριακών " + Environment.NewLine + "και ένα χυμό πορτοκάλι.";
                
            }
            if(var.midday)
            {
                textBlock.Text = "Τι θα λέγατε για ένα ελαφρύ γεύμα;";
            }
            if(var.afternoon)
            {
                textBlock.Text = "Αυτή την ώρα θα σας προτείναμε"+Environment.NewLine+"μια μπάρα δημητριακών "+ Environment.NewLine+"και ένα χυμό πορτοκάλι.";
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
