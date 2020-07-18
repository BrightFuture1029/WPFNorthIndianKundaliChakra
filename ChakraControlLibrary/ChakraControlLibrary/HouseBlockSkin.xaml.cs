using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class HouseBlockSkin : UserControl
    {
        public HouseBlockSkin()
        {
            HouseStatusList = new List<bool>();
            for (int i = 0; i < 12; i++)
                HouseStatusList.Add(false);

            InitializeComponent();
        }

        public ICommand HouseCheckCmd { get { return new RelayCommand<int>(HouseButtonClicked);  } }

        public List<bool> HouseStatusList { get; set; }

        private void HouseButtonClicked(int obj)
        {
            if (obj == 0 || obj > 11 || HouseCommand == null || 
                DependencyProperty.UnsetValue == HouseCommand) return;
            HouseCommand.Execute(new HouseState() { House = (HouseEnum)obj, IsChecked = HouseStatusList[obj - 1] });
        }

        public Brush FillBrush
        {
            get { return (Brush)GetValue(FillBrushProperty); }
            set { SetValue(FillBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FillBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FillBrushProperty =
            DependencyProperty.Register("FillBrush", typeof(Brush), typeof(HouseBlockSkin),
                new PropertyMetadata(null));

        public Brush ButtonCheckedBrush
        {
            get { return (Brush)GetValue(ButtonCheckedBrushProperty); }
            set { SetValue(ButtonCheckedBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonCheckedBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCheckedBrushProperty =
            DependencyProperty.Register("ButtonCheckedBrush", typeof(Brush), typeof(HouseBlockSkin),
                new PropertyMetadata(null));

        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(HouseBlockSkin),
                new PropertyMetadata(null));

        public ICommand HouseCommand
        {
            get { return (ICommand)GetValue(HouseCommandProperty); }
            set { SetValue(HouseCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HouseCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseCommandProperty =
            DependencyProperty.Register("HouseCommand", typeof(ICommand), typeof(HouseBlockSkin), new PropertyMetadata(null));       
    }
}