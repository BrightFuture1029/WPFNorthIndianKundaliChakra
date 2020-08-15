using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ChakraControlLibrary
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NorthIndianKundaliChart : UserControl,INotifyPropertyChanged
    {
        public NorthIndianKundaliChart()
        {
            Initialize_HouseBlockSkin();
            Initialize_TextKundaliControl();
            FillRashiNumberes(1);
            InitializeComponent();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SquarePointCollection)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CrossPointCollection)));
        }

        public Brush DefaultFillBrush
        {
            get { return (Brush)GetValue(DefaultFillBrushProperty); }
            set { SetValue(DefaultFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DefaultFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefaultFillBrushProperty =
            DependencyProperty.Register("DefaultFillBrush", typeof(Brush),
                typeof(NorthIndianKundaliChart), new PropertyMetadata(null));

        public Brush MouseOverFillBrush
        {
            get { return (Brush)GetValue(MouseOverFillBrushProperty); }
            set { SetValue(MouseOverFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverFillBrushProperty =
            DependencyProperty.Register("MouseOverFillBrush", typeof(Brush),
                typeof(NorthIndianKundaliChart), new PropertyMetadata(null));

        public Brush CheckedFillBrush
        {
            get { return (Brush)GetValue(CheckedFillBrushProperty); }
            set { SetValue(CheckedFillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckedFillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckedFillBrushProperty =
            DependencyProperty.Register("CheckedFillBrush", typeof(Brush),
                typeof(NorthIndianKundaliChart), new PropertyMetadata(null));

        public ObservableCollection<HouseElements> HouseDetailItemSource
        {
            get { return (ObservableCollection<HouseElements>)GetValue(HouseDetailItemSourceProperty); }
            set { SetValue(HouseDetailItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HouseDetailItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseDetailItemSourceProperty =
            DependencyProperty.Register("HouseDetailItemSource", 
                typeof(ObservableCollection<HouseElements>), 
                typeof(NorthIndianKundaliChart), 
                new PropertyMetadata(new PropertyChangedCallback(OnHouseDetailItemSource)));

        public static void OnHouseDetailItemSource(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var chart = d as NorthIndianKundaliChart;
            chart.PropertyChanged?.Invoke(chart, new PropertyChangedEventArgs(nameof(chart.HouseDetailItemSource)));
        }

        public DataTemplate HouseElementTemplate
        {
            get { return (DataTemplate)GetValue(HouseElementTemplateProperty); }
            set { SetValue(HouseElementTemplateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HouseElementTemplate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseElementTemplateProperty =
            DependencyProperty.Register("HouseElementTemplate", typeof(DataTemplate), typeof(NorthIndianKundaliChart), new PropertyMetadata(null));
    }

    public class HouseBlockConfiguration : DependencyObject
    {
        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(HouseBlockConfiguration), new PropertyMetadata(0));
    }
}
