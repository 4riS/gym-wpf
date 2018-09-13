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
    /// Interaction logic for pinakasPage.xaml
    /// </summary>
    public partial class pinakasPage : Page
    {
        public pinakasPage()
        {
            InitializeComponent();
            if (var.pool_water == "Medium")
            {
                radioButton1.IsChecked = true;
            } else if (var.pool_water == "Low") {
                radioButton.IsChecked = true;
            } else {
                radioButton2.IsChecked = true;
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

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {

            } else
            {
                try
                {
                    var.temperature = int.Parse(textBox.Text);
                } catch (Exception ring)
                {
                    MessageBox.Show("Κάτι πήγε λάθος με την θερμοκρασία. Θέλει μόνο αριθμούς. Προσπαθήστε ξανά !");
                }
            }

            if (radioButton.IsChecked == true)
            {
                var.pool_water = "Low";
            } else if (radioButton1.IsChecked == true)
            {
                var.pool_water = "Medium";
            } else
            {
                var.pool_water = "High";
            }
            Pages.poolPage poolP = new poolPage();
            this.NavigationService.Navigate(poolP);
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
