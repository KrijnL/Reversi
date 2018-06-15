using Cell;
using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PlayerViewModel
    {
        private GameViewModel Game;
        public Cell<string> Name { get; set; }
        public Player Player { get; private set; }
        public Cell<int> Score { get; set; }

        public PlayerViewModel(GameViewModel Game, Player player, string name)
        {
            this.Game = Game;
            this.Player = Player;
            this.Name = Cell.Cell.Create("name");
            this.Score = Cell.Cell.Create(Game.Board.CountStones(Player));
            Game.PropertyChanged += (s, e) =>
            {
                this.Score.Value = Game.Board.CountStones(Player);
            };
        }

    }
}
