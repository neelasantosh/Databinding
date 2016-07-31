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
//this reference gives new api i.e. OversrvableCollection
using System.Collections.ObjectModel;
using Microsoft.Phone.Shell;

namespace WindowsPhoneDataBinding
{
    public partial class MainPage : PhoneApplicationPage
    {
        //this will allow us to change listbox also. It automatically affects listbox associated with
        //is. It is very advanced than List api. Generally used for data binding
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            products.Add(new Product { 
                productId = 101, 
                productName = "Assasins Creed Revelations",
                productImage = "http://www.theultimategroup.com/m1.jpg", 
                productPrice=3400,
                status=false
            });
            products.Add(new Product
            {
                productId = 102,
                productName = "Counter Strike Go",
                productImage = "https://lh6.ggpht.com/onlNBInQHIZtB2rY24BwrEsUUKwE753ao1BAvvhOw2ePEN1IHIUjaR3gvlGd3jyKTdg=w300",
                productPrice = 5400,
                status=true
            });
            products.Add(new Product
            {
                productId = 103,
                productName = "Left 4 Dead 2",
                productImage = "http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/512/MetroUI-Apps-Mac-App-Store-icon.png",
                productPrice = 2540,
                status=true
            });
            products.Add(new Product
            {
                productId = 104,
                productName = "Left 4 Dead",
                productImage = "http://www.theultimategroup.com/m4.jpg",
                productPrice = 1890,
                status=false
            });
            products.Add(new Product
            {
                productId = 105,
                productName = "Mafia 2",
                productImage = "Mafia 2.png",
                productPrice = 3450,
                status=true
            });
        }

        private void GetProductsButton_Click(object sender, RoutedEventArgs e)
        {
            ProductListBox.ItemsSource = products;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product
            {
                productId=106,
                productImage="Deus Ex Human Revolution.png",
                productName="Deus Ex Human Revolution",
                productPrice=3120,
                status=true
            });
            products.Add(new Product
            {
                productId = 107,
                productImage = "Resident Evil 5.png",
                productName = "Resident Evil 5",
                productPrice = 4500,
                status = true
            });
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            ProductListBox.ItemsSource = null;
            ProductListBox.ItemsSource = products;
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            products.Add(new Product
            {
                productId = 106,
                productImage = "Deus Ex Human Revolution.png",
                productName = "Deus Ex Human Revolution",
                productPrice = 3120,
                status = true
            });
            products.Add(new Product
            {
                productId = 107,
                productImage = "Resident Evil 5.png",
                productName = "Resident Evil 5",
                productPrice = 4500,
                status = true
            });
        }

        private void ProductListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //It SelectedItem gives item which is clicked
            Product p = ProductListBox.SelectedItem as Product;
            PhoneApplicationService.Current.State["product"] = p;
            NavigationService.Navigate(new Uri("/ProductDetailsPage.xaml", UriKind.Relative));
        }
    }
}