using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChakraControlLibrary.OtherClasses
{
    /// <summary>
    /// Interaction logic for HouseElementItemsControl.xaml
    /// </summary>
    public partial class HouseElementItemsControl : ItemsControl
    {
        public HouseElementItemsControl()
        {
            InitializeComponent();
        }



        public int HouseNumber
        {
            get { return (int)GetValue(HouseNumberProperty); }
            set { SetValue(HouseNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HouseNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseNumberProperty =
            DependencyProperty.Register("HouseNumber", typeof(int), typeof(HouseElementItemsControl), new PropertyMetadata(0));


    }
}
