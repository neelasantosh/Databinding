using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WindowsPhoneDataBinding
{
    public class Product
    {
        public string productName { get; set; }
        public string productImage { get; set; }
        public double productPrice { get; set; }
        public int productId { get; set; }
        public bool status { get; set; }

        /*public bool _status { get { return status; } set { status = value; } }
        public int _productId { get { return productId; } set { productId = value; } }
        public string _productName { get { return productName; } set { productName = value; } }
        public string _productImage { get { return productImage; } set { productImage = value; } }
        public double _productPrice { get { return productPrice; } set { productPrice = value; } }*/

    }
}
