using PMS.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PMS.VM.Converter
{
    internal class TimeSpanToLength : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TimeSpan duration = (TimeSpan)value;
            double days = duration.TotalDays;
            double result = days * (double)(App.Current.Properties[Constant.TimeLineFactorID] ?? Constant.TimeLineFactor);

            // ToDo check this
            if (targetType == typeof(Thickness))
            {
                return new Thickness(result, 0, 0, 0);
            }
            else
            {
                return result;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
