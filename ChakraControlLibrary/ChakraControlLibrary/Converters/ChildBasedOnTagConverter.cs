using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace ChakraControlLibrary
{    
    public class ChildBasedOnTagConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is ObservableCollection<HouseElements> detailCollection &&
                int.TryParse((parameter ?? "").ToString(), out int index))
            {
                index--;
                return detailCollection.ElementAtOrDefault(index)?.HouseElementCollection;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
