﻿#pragma checksum "D:\Windows Phone Projects\WindowsPhoneDataBinding\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D4BA5373F8C46C1DAD08550E87C4B7E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WindowsPhoneDataBinding {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Button GetProductsButton;
        
        internal System.Windows.Controls.Button AddProductButton;
        
        internal System.Windows.Controls.ListBox ProductListBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WindowsPhoneDataBinding;component/MainPage.xaml", System.UriKind.Relative));
            this.GetProductsButton = ((System.Windows.Controls.Button)(this.FindName("GetProductsButton")));
            this.AddProductButton = ((System.Windows.Controls.Button)(this.FindName("AddProductButton")));
            this.ProductListBox = ((System.Windows.Controls.ListBox)(this.FindName("ProductListBox")));
        }
    }
}

