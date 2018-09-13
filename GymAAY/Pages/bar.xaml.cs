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
    /// Interaction logic for bar.xaml
    /// </summary>
    public partial class bar : Page
    {
        private SoundPlayer _soundPlayer;

        public bar()
        {
            _soundPlayer = new SoundPlayer("Music/Paganini.wav");
            InitializeComponent();
            if (var.radio_on == true)
            {
                button11.Visibility = Visibility.Visible;
                button12.Visibility = Visibility.Collapsed;
                _soundPlayer.Play();
            } else
            {
                button11.Visibility = Visibility.Collapsed;
                button12.Visibility = Visibility.Visible;
                _soundPlayer.Stop();
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

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Φρεσκότατος χυμός για 2 ευρώ";
            button4.Content = "Πολύ ωραία";
            button6.Content = "Άλλαξα γνώμη";
            button4.Click += buy;
            button6.Click += go_back;


        }

        void buy(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Θα πληρώσετε μετρητά " + Environment.NewLine + "ή με κάρτα;";
            button4.Content = "Μετρητά";
            button9.Visibility = Visibility.Visible;
            button4.Click += pay_cash;
        }


        void go_back(object sender, RoutedEventArgs e)
        {
            bar bar = new bar();
            this.NavigationService.Navigate(bar);
        }


        void pay_card(object sender, RoutedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Visible;
            textBlock3.Visibility = Visibility.Visible;
            textBlock4.Visibility = Visibility.Visible;
            textBox.Visibility = Visibility.Visible;
            textBox1.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            textBox3.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Visible;
        }


        void pay_cash(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Μη ξεχάσετε τα ρέστα σας";
            button4.Visibility = Visibility.Collapsed;
            button9.Visibility = Visibility.Collapsed;
            button6.Content = "Ευχαριστώ πολύ";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Μπάρα με σουσάμι μόνο για 1 ευρώ";
            button4.Content = "Πολύ ωραία";
            button6.Content = "Άλλαξα γνώμη";
            button4.Click += buy;
            button6.Click += go_back;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            elevatorPage elvp = new elevatorPage();
            this.NavigationService.Navigate(elvp);
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            button11.Visibility = Visibility.Collapsed;
            button12.Visibility = Visibility.Visible;
            var.radio_on = false;
            _soundPlayer.Stop();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            button11.Visibility = Visibility.Visible;
            button12.Visibility = Visibility.Collapsed;
            var.radio_on = true;
            _soundPlayer.Play();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Καλή συνέχεια";
            button4.Visibility = Visibility.Collapsed;
            button6.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Collapsed;
            textBlock2.Visibility = Visibility.Collapsed;
            textBlock3.Visibility = Visibility.Collapsed;
            textBlock4.Visibility = Visibility.Collapsed;
            textBox.Visibility = Visibility.Collapsed;
            textBox1.Visibility = Visibility.Collapsed;
            textBox2.Visibility = Visibility.Collapsed;
            textBox3.Visibility = Visibility.Collapsed;
            button8.Visibility = Visibility.Collapsed;
            button9.Visibility = Visibility.Collapsed;
            button4.Visibility = Visibility.Collapsed;
            button9.Visibility = Visibility.Collapsed;
            button6.Content = "Ευχαριστώ πολύ";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GymAAY μια εφαρμογή των Γεωργούλη Αριστοτέλη και Σανιδά Γεώργιου");

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Help.chm");

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Visible;
            textBlock3.Visibility = Visibility.Visible;
            textBlock4.Visibility = Visibility.Visible;
            textBox.Visibility = Visibility.Visible;
            textBox1.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            textBox3.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Visible;
        }

        private void Grid_Unloaded(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Stop();
        }
    }
}
