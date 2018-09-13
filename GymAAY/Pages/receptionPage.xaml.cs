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
    /// Interaction logic for receptionPage.xaml
    /// </summary>
    public partial class receptionPage : Page
    {
        public receptionPage()
        {
            InitializeComponent();
            if(controlPage.employee)
            {
                if (var.morning)
                    textBlock.Text = "Καλημέρα συνάδελφε";
                textBlock.Text = "Καλησπέρα συνάδελφε";
                button5.Visibility = Visibility.Collapsed;
                button4.Visibility = Visibility.Collapsed;
                button6.Visibility = Visibility.Visible;
                button7.Visibility = Visibility.Visible;
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
            Pages.receptionMemberPage rcptMmbrPg = new receptionMemberPage();
            this.NavigationService.Navigate(rcptMmbrPg);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            elevatorPage elvtrPg = new elevatorPage();
            this.NavigationService.Navigate(elvtrPg);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Pages.controlPage cr = new controlPage();
            this.NavigationService.Navigate(cr);
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
