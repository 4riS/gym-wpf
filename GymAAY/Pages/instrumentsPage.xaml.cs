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
    /// Interaction logic for instrumentsPage.xaml
    /// </summary>
    public partial class instrumentsPage : Page
    {
        private SoundPlayer soundWave;

        public instrumentsPage()
        {
            soundWave = new SoundPlayer("Music/wind-1.wav");
            InitializeComponent();

            if (var.air_condition == true)
            {
                button9.Visibility = Visibility.Collapsed;
                button8.Visibility = Visibility.Visible;
                soundWave.Play();
            }
            else
            {
                button9.Visibility = Visibility.Visible;
                button8.Visibility = Visibility.Collapsed;
                soundWave.Stop();
            }

            if (var.gymLights == true)
            {
                button14.Visibility = Visibility.Visible;
                button16.Visibility = Visibility.Collapsed;
                image2.Visibility = Visibility.Visible;
                image1.Visibility = Visibility.Collapsed;
            }
            else
            {
                button14.Visibility = Visibility.Collapsed;
                button16.Visibility = Visibility.Visible;
                image2.Visibility = Visibility.Collapsed;
                image1.Visibility = Visibility.Visible;
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
            Pages.bikePage bkrun = new bikePage();
            this.NavigationService.Navigate(bkrun);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Pages.runningPage run = new runningPage();
            this.NavigationService.Navigate(run);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            elevatorPage elvtrPg = new elevatorPage();
            this.NavigationService.Navigate(elvtrPg);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            button9.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Collapsed;
            var.air_condition = false;
            soundWave.Stop();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button9.Visibility = Visibility.Collapsed;
            button8.Visibility = Visibility.Visible;
            var.air_condition = true;
            soundWave.Play();
        }

        private void Grid_Unloaded(object sender, RoutedEventArgs e)
        {
            soundWave.Stop();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GymAAY μια εφαρμογή των Γεωργούλη Αριστοτέλη και Σανιδά Γεώργιου");

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Help.chm");

        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            button14.Visibility = Visibility.Visible;
            button16.Visibility = Visibility.Collapsed;
            image2.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Collapsed;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            button14.Visibility = Visibility.Collapsed;
            button16.Visibility = Visibility.Visible;
            image2.Visibility = Visibility.Collapsed;
            image1.Visibility = Visibility.Visible;
        }
    }
}
