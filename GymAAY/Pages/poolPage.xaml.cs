using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for poolPage.xaml
    /// </summary>
    public partial class poolPage : Page
    {

        private SoundPlayer sd;

        public poolPage()
        {
            sd = new SoundPlayer("Music/al.wav");

            InitializeComponent();
            textBlock1.Text = var.temperature.ToString() + "°C";
            textBlock2.Text = var.pool_water.ToString();

            if (var.peopleInPool != 0)
            {
                textBlock5.Text += " " + var.peopleInPool.ToString() + " άτομα";
                var.alarm_pool = true;
                textBlock3.Text = "ON";
                sd.Play();
            } else
            {
                textBlock5.Text = "Δεν βρίσκεται άτομα στην πισίνα";
                var.alarm_pool = false;
                textBlock3.Text = "OFF";
            }

            if (controlPage.employee)
            {
                textBlock.Text = "Συνάδελφε, σε αφήνω μόνο";
                textBlock4.Text = "Με φώναξες συνάδελφε ; Τι με ήθελες ;";
                button7.Content = "Βαρέθηκα. Επιστρέφω πίσω";
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

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            image.Visibility = Visibility.Collapsed;
            image1.Visibility = Visibility.Collapsed;
            textBlock.Visibility = Visibility.Collapsed;
            button6.Visibility = Visibility.Collapsed;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Visible;
            image5.Visibility = Visibility.Collapsed;
            textBlock5.Visibility = Visibility.Collapsed;
            var.isVisitedPool = true;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Pages.pinakasPage pnkp = new pinakasPage();
            this.NavigationService.Navigate(pnkp);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (var.isVisitedPool == true)
            {
                image.Visibility = Visibility.Collapsed;
                image1.Visibility = Visibility.Collapsed;
                textBlock.Visibility = Visibility.Collapsed;
                button6.Visibility = Visibility.Collapsed;
                button4.Visibility = Visibility.Visible;
                button5.Visibility = Visibility.Visible;
                image5.Visibility = Visibility.Collapsed;
                textBlock5.Visibility = Visibility.Collapsed;
            }

            textBlock3.Text += " " + var.peopleInPool.ToString() + " people";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            image.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Visible;
            textBlock4.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Collapsed;
            button5.Visibility = Visibility.Collapsed;
            button7.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Visible;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Pages.elevatorPage elvpg = new elevatorPage();
            this.NavigationService.Navigate(elvpg);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            image.Visibility = Visibility.Collapsed;
            image1.Visibility = Visibility.Collapsed;
            textBlock4.Visibility = Visibility.Collapsed;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Visible;
            button7.Visibility = Visibility.Collapsed;
            button8.Visibility = Visibility.Collapsed;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            var.alarm_pool = true;
            var.peopleInPool++;
            textBlock3.Text = "ON " + var.peopleInPool.ToString() + " people";
            button9.Visibility = Visibility.Collapsed;
            button10.Visibility = Visibility.Visible;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            var.peopleInPool--;
            if (var.peopleInPool == 0)
            {
                var.alarm_pool = false;
                textBlock3.Text = "OFF 0 people";
            } else
            {
                textBlock3.Text = "ON " + var.peopleInPool.ToString() + " people";
            }
            button10.Visibility = Visibility.Collapsed;
            button9.Visibility = Visibility.Visible;
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
