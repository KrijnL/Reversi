using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View
{
    class PLayerToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine((Player)value);
            Debug.WriteLine((Player)value == Player.BLACK);
            if ((Player)value == Player.BLACK)
            {
                Debug.WriteLine("Returning black");
                return Brushes.Black;
                
            }
            if ((Player)value == Player.WHITE)
            {
                Debug.WriteLine("Returning white");
                return Brushes.White;
            }
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
