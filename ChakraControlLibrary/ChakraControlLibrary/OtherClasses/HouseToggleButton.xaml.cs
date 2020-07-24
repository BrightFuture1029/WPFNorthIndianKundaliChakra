using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChakraControlLibrary
{
    /// <summary>
    /// Interaction logic for tt.xaml
    /// </summary>
    public partial class HouseToggleButton : ToggleButton
    {
        public HouseToggleButton()
        {
            InitializeComponent();
        }

        public Geometry GeometryPath { get; set; }

        public int HouseNumber
        {
            get { return (int)GetValue(HouseNumberProperty); }
            set { SetValue(HouseNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HouseNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseNumberProperty =
            DependencyProperty.Register("HouseNumber", typeof(int), typeof(HouseToggleButton), new PropertyMetadata(0));

        public Brush DefaultFillBrush
        {
            get { return (Brush)GetValue(DefaultFillBrushProperty); }
            set { SetValue(DefaultFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DefaultFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefaultFillBrushProperty =
            DependencyProperty.Register("DefaultFillBrush", typeof(Brush),
                typeof(HouseToggleButton), new PropertyMetadata(null));

        public Brush MouseOverFillBrush
        {
            get { return (Brush)GetValue(MouseOverFillBrushProperty); }
            set { SetValue(MouseOverFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverFillBrushProperty =
            DependencyProperty.Register("MouseOverFillBrush", typeof(Brush),
                typeof(HouseToggleButton), new PropertyMetadata(null));

        public Brush CheckedFillBrush
        {
            get { return (Brush)GetValue(CheckedFillBrushProperty); }
            set { SetValue(CheckedFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckedFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckedFillBrushProperty =
            DependencyProperty.Register("CheckedFillBrush", typeof(Brush),
                typeof(HouseToggleButton), new PropertyMetadata(null));
    }
}
