using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WindowsPhoneDataBinding
{
    public partial class ProductDetailsPage : PhoneApplicationPage
    {
        public ProductDetailsPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            Product p = PhoneApplicationService.Current.State["product"] as Product;
            ProductDetailsStackPanel.DataContext = p;
        }
    }
}