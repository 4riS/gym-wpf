using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
    /// Interaction logic for gymMemberLogin.xaml
    /// </summary>
    public partial class gymMemberLogin : Page
    {
        String connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db1.mdb";
        OleDbConnection conn;

        public gymMemberLogin()
        {
            conn = new OleDbConnection(connectionstring);
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
            conn.Open();

            String query = "Select id,username from [user] where username='" + textBox.Text + "'  and pass='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                gymGuestPage.current_user_id = rdr.GetValue(1).ToString();
                Pages.instrumentsPage instruments = new instrumentsPage();
                this.NavigationService.Navigate(instruments);
            }
            else
            {
                MessageBox.Show("Δεν βρέθηκε χρήστης με αυτά τα στοιχεία !");
            }
            conn.Close();
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
