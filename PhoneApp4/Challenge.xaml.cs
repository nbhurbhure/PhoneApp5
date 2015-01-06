using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp4
{
    public partial class Challenge : PhoneApplicationPage
    {
        public Challenge()
        {
            InitializeComponent();
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Calculation.xaml", UriKind.Relative));
        }
    }
}