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
    /// Interaction logic for elevatorPage.xaml
    /// </summary>
    public partial class elevatorPage : Page
    {
        public elevatorPage()
        {
            InitializeComponent();
            if (controlPage.employee)
            {
                textBlock.Visibility = Visibility.Collapsed;
                image.Visibility = Visibility.Collapsed;
                image1.Visibility = Visibility.Collapsed;
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
            if (gymGuestPage.current_user_id == null)
            {
                Pages.gymGuestPage gmGst = new gymGuestPage();
                this.NavigationService.Navigate(gmGst);
            }
            else if (controlPage.employee)
            {
                Pages.instrumentsPage instr = new instrumentsPage();
                this.NavigationService.Navigate(instr);
            }
            else
            {
                Pages.instrumentsPage instr = new instrumentsPage();
                this.NavigationService.Navigate(instr);
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (gymGuestPage.current_user_id == null)
            {
                Pages.poolLogin pl = new poolLogin();
                this.NavigationService.Navigate(pl);
            }
            else if (controlPage.employee)
            {
                Pages.poolPage plpg = new poolPage();
                this.NavigationService.Navigate(plpg);
            }
            else
            {
                Pages.poolPage plpg = new poolPage();
                this.NavigationService.Navigate(plpg);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Pages.cafePage cf = new cafePage();
            this.NavigationService.Navigate(cf);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Pages.receptionPage recpt = new receptionPage();
            this.NavigationService.Navigate(recpt);
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
