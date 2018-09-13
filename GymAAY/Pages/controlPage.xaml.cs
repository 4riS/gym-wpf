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
    /// Interaction logic for controlPage.xaml
    /// </summary>
    public partial class controlPage : Page
    {
        public static Boolean employee;
        public controlPage()
        {
            InitializeComponent();
            employee = true;
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
            Pages.receptionPage recpt = new receptionPage();
            this.NavigationService.Navigate(recpt);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (var.gymLights == true)
            {
                button4.Visibility = Visibility.Visible;
                button6.Visibility = Visibility.Collapsed;
            } else
            {
                button4.Visibility = Visibility.Visible;
                button6.Visibility = Visibility.Collapsed;
            }

            if (var.air_condition)
            {
                button8.Visibility = Visibility.Collapsed;
                button7.Visibility = Visibility.Visible;
            }
            else
            {
                button8.Visibility = Visibility.Visible;
                button7.Visibility = Visibility.Collapsed;
            }

            if (var.tv_on)
            {
                button9.Visibility = Visibility.Visible;
                button10.Visibility = Visibility.Collapsed;
            }
            else
            {
                button9.Visibility = Visibility.Collapsed;
                button10.Visibility = Visibility.Visible;
            }

            if (var.radio_on)
            {
                button11.Visibility = Visibility.Visible;
                button12.Visibility = Visibility.Collapsed;
            }
            else
            {
                button11.Visibility = Visibility.Collapsed;
                button12.Visibility = Visibility.Visible;
            }

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            button4.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Collapsed;
            var.gymLights = true;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            button6.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Collapsed;
            var.gymLights = false;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button7.Visibility = Visibility.Collapsed;
            button8.Visibility = Visibility.Visible;
            var.air_condition = false;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            button7.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Collapsed;
            var.air_condition = true;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button9.Visibility = Visibility.Collapsed;
            button10.Visibility = Visibility.Visible;
            var.tv_on = false;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            button9.Visibility = Visibility.Visible;
            button10.Visibility = Visibility.Collapsed;
            var.tv_on = true;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            button11.Visibility = Visibility.Collapsed;
            button12.Visibility = Visibility.Visible;
            var.radio_on = false;
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            button11.Visibility = Visibility.Visible;
            button12.Visibility = Visibility.Collapsed;
            var.radio_on = true;
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
