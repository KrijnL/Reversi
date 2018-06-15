using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cell;
using Model.Reversi;
using System.Windows.Media;

namespace ViewModel
{
    public class PlayerOptionsViewModel
    {
        public Cell<Color> PlayerBColor { get; set; }
        public Cell<Color> PlayerWColor { get; set; }

        public Cell<string> PlayerBName { get; set; }
        public Cell<string> PlayerWName { get; set; }

        public PlayerOptionsViewModel()
        {
            PlayerBColor = Cell.Cell.Create((Color)ColorConverter.ConvertFromString("Black"));
            PlayerWColor = Cell.Cell.Create((Color)ColorConverter.ConvertFromString("White"));

            PlayerBName = Cell.Cell.Create("Bapediboop");
            PlayerWName = Cell.Cell.Create("White");
        }

        internal string GetName(Player player)
        {
            if(player == Player.BLACK)
            {
                return PlayerBName.Value;
            }
            else
            {
                return PlayerWName.Value;
            }

        }

        internal void SetName(Player player, string name)
        {
            if(player == Player.BLACK)
            {
                this.PlayerBName.Value = name;
            }
            else
            {
                this.PlayerWName.Value = name;
            }
        }

        internal Color GetColor(Player player)
        {
            return player == Player.BLACK ? PlayerBColor.Value : PlayerWColor.Value;
        }

        
    }
}
