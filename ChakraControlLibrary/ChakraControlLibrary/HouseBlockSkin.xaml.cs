using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class HouseBlockSkin : UserControl,INotifyPropertyChanged
    {
        public HouseBlockSkin()
        {
            HouseStatusList = new List<bool>();
            var collection = new ObservableCollection<HouseBlockDetail>();

            for (int i = 0; i < 12; i++)
            {
                HouseStatusList.Add(false);
                collection.Add(new HouseBlockDetail());
            }
            
            InitializeComponent();
            HouseBlockDetailCollection = collection;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HouseBlockDetailCollection)));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand HouseCheckCmd { get { return new RelayCommand<int>(HouseButtonClicked);  } }

        public List<bool> HouseStatusList { get; set; }

        private void HouseButtonClicked(int obj)
        {
            if (obj == 0 || obj > 11 || HouseCommand == null || 
                DependencyProperty.UnsetValue == HouseCommand) return;

            HouseCommand.Execute(new HouseBlockDetail() { House = (HouseEnum)obj, IsChecked = HouseStatusList[obj - 1] });
        }

        public ICommand HouseCommand
        {
            get { return (ICommand)GetValue(HouseCommandProperty); }
            set { SetValue(HouseCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HouseCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseCommandProperty =
            DependencyProperty.Register("HouseCommand", typeof(ICommand), typeof(HouseBlockSkin), new PropertyMetadata(null));

        public ObservableCollection<HouseBlockDetail> HouseBlockDetailCollection
        {
            get { return (ObservableCollection<HouseBlockDetail>)GetValue(HouseBlockDetailCollectionProperty); }
            set { SetValue(HouseBlockDetailCollectionProperty, value); }
        }
        
        // Using a DependencyProperty as the backing store for HouseBlockDetailCollection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HouseBlockDetailCollectionProperty =
            DependencyProperty.Register("HouseBlockDetailCollection", typeof(ObservableCollection<HouseBlockDetail>), typeof(HouseBlockSkin), new PropertyMetadata(null));       
    }
}