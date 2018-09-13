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
    /// Interaction logic for receptionMemberPage.xaml
    /// </summary>
    public partial class receptionMemberPage : Page
    {
        public receptionMemberPage()
        {
            InitializeComponent();
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
            controlPage ct = new controlPage();
            this.NavigationService.Navigate(ct);
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
