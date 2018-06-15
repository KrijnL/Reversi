using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace View
{
    public class StringToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string player = "";
            if (value is Player)
            {
                if ((Player)value == Player.WHITE)
                    player = "W";
                if ((Player)value == Player.BLACK)
                    player = "B";
            }
            else
            {
                player = value as string;
            }
            if (player.Equals("B"))
            {
                return Brushes.Black;
            }else if (player.Equals("W"))
            {
                return Brushes.White;
            }
            else
            {
                return Brushes.Transparent;
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
