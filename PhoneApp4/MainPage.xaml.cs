using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp4.Resources;

namespace PhoneApp4
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnChallenge_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Challenge.xaml",UriKind.Relative));
        }

        private void btnPractice_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Challenge.xaml", UriKind.Relative));
        }

        private void btnHighscore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HighScore.xaml", UriKind.Relative));
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }

        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Information.xaml", UriKind.Relative));
        }
    }
}