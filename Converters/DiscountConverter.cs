using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace pract_7_Hojaeva.Converters
{
    public class DiscountConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            if (value is double d)
                return System.Convert.ToDouble(d * 100);

            return String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            if (value == null)
                return null;

            if (double.TryParse(value.ToString( ), NumberStyles.Float, culture,
                out double result))
                return result / 100;

            return 0;
        }
    }
}
