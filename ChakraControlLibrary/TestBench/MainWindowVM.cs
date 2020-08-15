using ChakraControlLibrary;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace TestBench
{
    public class MainWindowVM : ObservableObject
    {
        public const string Sample1 = "Sample 1";
        public const string Sample2 = "Sample 2";
        public const string Sample3 = "Sample 3";

        public const string Mangal = "Mangal";
        public const string Shukra = "Shukra";
        public const string Budh = "Budh";
        public const string Surya = "Surya";
        public const string Chandra = "Chandra";
        public const string Guru = "Guru";
        public const string Shani = "Shani";
        public const string Rahu = "Rahu";
        public const string Ketu = "Ketu";

        public MainWindowVM()
        {
            KundaliTemplateList = new ObservableCollection<string>();
            KundaliTemplateList.Add(Sample1);
            KundaliTemplateList.Add(Sample2);
            KundaliTemplateList.Add(Sample3);

            HouseDetailCollection = new ObservableCollection<HouseElements>();
        }

        private ObservableCollection<string> _kundaliTemplateList;

        public ObservableCollection<string> KundaliTemplateList
        {
            get { return _kundaliTemplateList; }
            set
            {
                _kundaliTemplateList = value;
                RaisePropertyChanged(nameof(KundaliTemplateList));
            }
        }

        private string _selectedKundaliTemplate;

        public string SelectedKundaliTemplate
        {
            get { return _selectedKundaliTemplate; }
            set { _selectedKundaliTemplate = value; RaisePropertyChanged(nameof(SelectedKundaliTemplate)); }
        }

        private int _startRashiNumber;

        public int StartRashiNumber
        {
            get { return _startRashiNumber; }
            set { _startRashiNumber = value; RaisePropertyChanged(nameof(StartRashiNumber)); }
        }

        public ICommand Load { get { return new LocalDelegateCommand(OnLoad); } }

        private ObservableCollection<HouseElements> houseDetailCollection;

        public ObservableCollection<HouseElements> HouseDetailCollection
        {
            get { return houseDetailCollection; }
            set { houseDetailCollection = value; RaisePropertyChanged(nameof(HouseDetailCollection)); }
        }

        public void OnLoad()
        {
            if (string.IsNullOrEmpty(SelectedKundaliTemplate)) return;
            if (SelectedKundaliTemplate == Sample1)
            {
                var cols = new ObservableCollection<HouseElements>();

                StartRashiNumber = 10;
                for (int i = 0; i < 12; i++)
                    cols.Add(new HouseElements() { HouseElementCollection = new ObservableCollection<HouseElement>() });

                cols [0].HouseElementCollection.Add(new HouseElement() { DisplayName = Guru });
                cols [3].HouseElementCollection.Add(new HouseElement() { DisplayName = Rahu });
                cols [9].HouseElementCollection.Add(new HouseElement() { DisplayName = Ketu });
                cols [9].HouseElementCollection.Add(new HouseElement() { DisplayName = Mangal });
                cols[10].HouseElementCollection.Add(new HouseElement() { DisplayName = Shani });

                cols [11].HouseElementCollection.Add(new HouseElement() { DisplayName = Surya });
                cols [11].HouseElementCollection.Add(new HouseElement() { DisplayName = Shukra });
                cols [11].HouseElementCollection.Add(new HouseElement() { DisplayName = Budh });
                cols[11].HouseElementCollection.Add(new HouseElement() { DisplayName = Chandra });
                HouseDetailCollection = cols;
                //RaisePropertyChanged(nameof());
            }
        }
    }
}