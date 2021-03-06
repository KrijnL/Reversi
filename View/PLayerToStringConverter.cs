﻿using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using ViewModel;

namespace View
{
    public class PlayerToStringConverter : IMultiValueConverter

    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] != null)
            {
                Player player = values[0] as Player;
                PlayerOptionsViewModel options = values[1] as PlayerOptionsViewModel;

                if (player == Player.BLACK)
                {
                    return options.PlayerBName.Value;
                }
                else if (player == Player.WHITE)
                {
                    return options.PlayerWName.Value;
                }
            }
            return "GAME OVER";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
