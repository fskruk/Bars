using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApp.Utils
{
	public class ActualityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value) >= DateTime.Now.AddDays(-60);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
