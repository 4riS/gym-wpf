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
using System.Data;
using System.Data.OleDb;
using System.Windows.Threading;



namespace GymAAY.Pages
{
    /// <summary>
    /// Interaction logic for runningPage.xaml
    /// </summary>
    public partial class runningPage : Page
    {

        int i = 0;
        String connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db1.mdb";
        OleDbConnection conn;
        DispatcherTimer timer = new DispatcherTimer();


        public runningPage()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionstring);
        }



        private void button_close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_min(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        DateTime start;

        private void timer_Tick(object sender, EventArgs e)
        {

            label7.Content = Convert.ToString(DateTime.Now.AddTicks(-1 * (DateTime.Now.Ticks % TimeSpan.TicksPerSecond)) - start);
        }

        private int getWeight()
        {
            conn.Open();

            String query = "Select weight from [user] where username='" + gymGuestPage.current_user_id + "'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader rdr = cmd.ExecuteReader();
            int weight = 0;
            while (rdr.Read())
            {
                weight = Convert.ToInt32(rdr.GetValue(0));

            }
            conn.Close();

            label3.Visibility = Visibility.Collapsed;
            textBox1.Visibility = Visibility.Collapsed;
            button.Visibility = Visibility.Collapsed;
            return weight;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double height = double.Parse(textBox1.Text) / 100.00;
                double bmi = (double)getWeight() / Math.Pow(height, 2);
                label5.Content = bmi.ToString("N1");
                button5.Visibility = System.Windows.Visibility.Visible;
                if (bmi >= 18.5 && bmi <= 24.9)
                {
                    image.Visibility = System.Windows.Visibility.Visible;
                }
                else if (bmi < 18.5)
                {
                    MessageBox.Show("You need to eat");
                }
                else
                {
                    image1.Visibility = System.Windows.Visibility.Visible;
                }
            }
            catch
            {
                MessageBox.Show("Please enter your height in centimeters");
            }


        }





        private void button1_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
            timer.Start(); ;
            start = DateTime.Now.AddTicks(-1 * (DateTime.Now.Ticks % TimeSpan.TicksPerSecond));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("advanced");

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            image2.Visibility = System.Windows.Visibility.Visible;

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            i++;
            label1.Content = i;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (i > 0)
            {


                i--;
                label1.Content = i;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            image.Visibility = System.Windows.Visibility.Collapsed;
            image1.Visibility = System.Windows.Visibility.Collapsed;
            image2.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            Pages.instrumentsPage instruments = new instrumentsPage();
            this.NavigationService.Navigate(instruments);
        }

        private void buttoninfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GymAAY μια εφαρμογή των Γεωργούλη Αριστοτέλη και Σανιδά Γεώργιου");

        }

        private void buttonhelp_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Help.chm");

        }
    }
}
