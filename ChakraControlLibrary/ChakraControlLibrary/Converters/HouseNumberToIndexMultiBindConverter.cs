using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace ChakraControlLibrary.Converters
{
    public class SampleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class HouseNumberToIndexMultiBindConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2 || values.Any(x=> x==null || DependencyProperty.UnsetValue.Equals(x))) return null;

            var list = values[0] as IEnumerable<HouseElements>;

            if (list == null || list.Count() == 0) return null;

            var number = (int)values[1];
            number--;

            return list?.ElementAtOrDefault(number).HouseElementCollection;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
