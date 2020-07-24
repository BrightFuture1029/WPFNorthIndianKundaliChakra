using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChakraControlLibrary
{
    public class HouseElement : ObservableObject
    {
        public string DisplayName { get; set; }
    }

    public class HouseElements : ObservableObject
    {
        public ObservableCollection<HouseElement> HouseElementCollection { get; set; }
        public string Name { get; set; }
    }

    public enum HouseEnum
    {
        House1 = 1,
        House2,
        House3,
        House4,
        House5,
        House6,
        House7,
        House8,
        House9,
        House10,
        House11,
        House12,
    }
}
