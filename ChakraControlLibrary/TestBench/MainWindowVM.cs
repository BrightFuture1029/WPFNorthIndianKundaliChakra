using ChakraControlLibrary;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TestBench
{
    public class MainWindowVM : ObservableObject
    {
        public MainWindowVM()
        {
            var coll = new ObservableCollection<HouseElements>();
            for (int i = 0; i < 12; i++)
            {
                coll.Add(new HouseElements()
                {
                    HouseElementCollection = new ObservableCollection<HouseElement>()
                    {
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                        new HouseElement(){ DisplayName="abcdd"},
                    }
                });
            }

            HouseDetailCollection = coll;
        }

        private ObservableCollection<HouseElements> houseDetailCollection;

        public ObservableCollection<HouseElements> HouseDetailCollection
        {
            get { return houseDetailCollection; }
            set { houseDetailCollection = value; RaisePropertyChanged(nameof(HouseDetailCollection)); }
        }
    }
}
