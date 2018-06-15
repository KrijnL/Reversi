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
        private PlayerOptionsViewModel options;
        public string Name
        {
            get
            {
                return options.GetName(Player);
            }
        }
        public Player Player { get; private set; }
        public Cell<int> Score { get; set; }
        public PlayerOptionsViewModel Options { get; private set; }
        //public string Color { get; set; }

        public PlayerViewModel(GameViewModel Game, Player player, PlayerOptionsViewModel options)
        {
            this.Game = Game;
            this.Player = player;
            this.options = options;
            this.Score = Cell.Cell.Create(Game.Board.CountStones(Player));
            Game.PropertyChanged += (s, e) =>
            {
                this.Score.Value = Game.Board.CountStones(Player);
            };
        }

    }
}
