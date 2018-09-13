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
using System.Windows.Threading;

namespace GymAAY.Pages
{
    /// <summary>
    /// Interaction logic for bikePage.xaml
    /// </summary>
    public partial class bikePage : Page
    {
        double dist = 00.0;
        DispatcherTimer timer = new DispatcherTimer();

        public bikePage()
        {
            InitializeComponent();
        }

        DateTime start;

        private void timer_Tick(object sender, EventArgs e)
        {

            label.Content = Convert.ToString(DateTime.Now.AddTicks(-1 * (DateTime.Now.Ticks % TimeSpan.TicksPerSecond)) - start);
            dist += 0.1;
            label1.Content = dist.ToString("N1"); ;

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
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
            timer.Start(); ;
            start = DateTime.Now.AddTicks(-1 * (DateTime.Now.Ticks % TimeSpan.TicksPerSecond));
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Pages.instrumentsPage instruments = new instrumentsPage();
            this.NavigationService.Navigate(instruments);
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
