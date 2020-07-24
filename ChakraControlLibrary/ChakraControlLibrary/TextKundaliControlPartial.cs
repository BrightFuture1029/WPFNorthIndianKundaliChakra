using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace ChakraControlLibrary
{
    public partial class NorthIndianKundaliChart: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Initialize_TextKundaliControl()
        {
            RashiNumbers = new List<int>();
            PopulatePoints();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            PopulatePoints();
        }

        private void PopulatePoints()
        {
            double width = ActualWidth;
            double height = ActualHeight;
            double midWidth = ActualWidth / 2;
            double midHeight = ActualHeight / 2;

            //300,0 0,300 300,600 600,300 300,0
            PointCollection points = new PointCollection();
            points.Add(new Point(midWidth, 0));
            points.Add(new Point(0, midHeight));
            points.Add(new Point(midWidth, height));
            points.Add(new Point(width, midHeight));
            points.Add(new Point(midWidth, 0));

            SquarePointCollection = points;

            //0,0 600,0 0,600 600,600 0,0
            PointCollection pointsCross = new PointCollection();
            pointsCross.Add(new Point(0, 0));
            pointsCross.Add(new Point(width, 0));
            pointsCross.Add(new Point(0, height));
            pointsCross.Add(new Point(width, height));
            pointsCross.Add(new Point(0, 0));
            CrossPointCollection = pointsCross;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SquarePointCollection)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CrossPointCollection)));
        }

        public PointCollection SquarePointCollection { get; set; }
        public PointCollection CrossPointCollection { get; set; }

        public int StartRashiNumber
        {
            get { return (int)GetValue(StartRashiNumberProperty); }
            set { SetValue(StartRashiNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StartRashiNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartRashiNumberProperty =
            DependencyProperty.Register("StartRashiNumber", typeof(int), 
                typeof(NorthIndianKundaliChart), new PropertyMetadata(1, new PropertyChangedCallback(OnRashiNumber)));

        private static void OnRashiNumber(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctrl = d as NorthIndianKundaliChart;
            ctrl.FillRashiNumberes((int) e.NewValue);
        }

        private void FillRashiNumberes(int startNum)
        {
            RashiNumbers.Clear();
            for (int i = startNum, j = 0; j < 12; i++, j++)
            {
                if (i > 12) i = 1;
                RashiNumbers.Add(i);
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RashiNumbers)));
        }

        public List<int> RashiNumbers { get; set; }

        public ObservableCollection<HouseElements> PlanetDetails
        {
            get { return (ObservableCollection<HouseElements>)GetValue(PlanetDetailsProperty); }
            set { SetValue(PlanetDetailsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlanetDetails.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlanetDetailsProperty =
            DependencyProperty.Register("PlanetDetails", typeof(ObservableCollection<HouseElements>), typeof(NorthIndianKundaliChart), new PropertyMetadata(null));
    }
}
