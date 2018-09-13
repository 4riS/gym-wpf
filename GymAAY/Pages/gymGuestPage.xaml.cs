﻿using System;
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
    /// Interaction logic for gymGuestPage.xaml
    /// </summary>
    public partial class gymGuestPage : Page
    {
        public static String current_user_id = null;

        public gymGuestPage()
        {
            InitializeComponent();
            if (controlPage.employee)
            {
                textBlock.Text = "Όλα καλά εδώ";
                button4.Content = "Μια ματιά θα ρίξω";
                button5.Content = "Οκ, πάω στο γραφείο";
                button4.Click += help;
                button5.Click += go_back;

            }
        }

        private void help(object sender, RoutedEventArgs e)
        {
            Pages.instrumentsPage instruments = new instrumentsPage();
            this.NavigationService.Navigate(instruments);
        }

        private void go_back(object sender, RoutedEventArgs e)
        {
            elevatorPage elvtrPg = new elevatorPage();
            this.NavigationService.Navigate(elvtrPg);
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
            button4.Visibility = System.Windows.Visibility.Collapsed;
            button5.Visibility = System.Windows.Visibility.Collapsed;
            textBlock.Visibility = System.Windows.Visibility.Collapsed;
            textBlock1.Visibility = System.Windows.Visibility.Visible;
            button6.Visibility = System.Windows.Visibility.Visible;
            button7.Visibility = System.Windows.Visibility.Visible;
            button8.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button4.Visibility = System.Windows.Visibility.Collapsed;
            button5.Visibility = System.Windows.Visibility.Collapsed;
            textBlock.Visibility = System.Windows.Visibility.Collapsed;
            textBlock1.Visibility = System.Windows.Visibility.Visible;
            button8.Visibility = System.Windows.Visibility.Visible;
            button7.Visibility = System.Windows.Visibility.Visible;
            button6.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button4.Visibility = System.Windows.Visibility.Visible;
            button5.Visibility = System.Windows.Visibility.Visible;
            textBlock.Visibility = System.Windows.Visibility.Visible;
            textBlock1.Visibility = System.Windows.Visibility.Collapsed;
            button6.Visibility = System.Windows.Visibility.Collapsed;
            button7.Visibility = System.Windows.Visibility.Collapsed;
            button8.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Pages.gymMemberLogin gmMmbrLg = new gymMemberLogin();
            this.NavigationService.Navigate(gmMmbrLg);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Pages.gymMemberRegister gmMmbrRg = new gymMemberRegister();
            this.NavigationService.Navigate(gmMmbrRg);
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            elevatorPage elvtrPg = new elevatorPage();
            this.NavigationService.Navigate(elvtrPg);
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