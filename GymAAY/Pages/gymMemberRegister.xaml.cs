using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for gymMemberRegister.xaml
    /// </summary>
    public partial class gymMemberRegister : Page
    {
        String connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db1.mdb";
        OleDbConnection conn;

        public gymMemberRegister()
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
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [user] ([username],[pass],[weight]) values (?,?,?)";
            cmd.Parameters.AddWithValue("@username", textBox.Text);
            cmd.Parameters.AddWithValue("@pass", textBox1.Text);
            cmd.Parameters.AddWithValue("@weight", textBox2.Text);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
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
