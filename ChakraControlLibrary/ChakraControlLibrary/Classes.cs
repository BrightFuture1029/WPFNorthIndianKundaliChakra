using System;
using System.Collections.Generic;
using System.Text;

namespace ChakraControlLibrary
{
    public class HouseState
    {
        public HouseEnum House { get; set; }
        public bool IsChecked { get; set; }
    }

    public class PlanetDetail
    {
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
