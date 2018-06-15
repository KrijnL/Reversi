using Cell;
using DataStructures;
using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BoardRowViewModel
    {
        private int rowNumber;

        public GameViewModel Game { get; set; }

        public PlayerOptionsViewModel Options { get; set; }

        public List<BoardSquareViewModel> Squares
        {
            get
            {
                List<BoardSquareViewModel> squares = new List<BoardSquareViewModel>();
                for(int i = 0; i<Game.Board.Width; i++)
                {
                    var position = new Vector2D(i, rowNumber);
                    var owner = Game.Board[position];
                    string ownerString = "";
                    if (owner != null)
                    {
                        ownerString = owner.ToString();
                    }

                    squares.Add(new BoardSquareViewModel(Game, position, Options));
                }
                return squares;
            }
        }

        

        public BoardRowViewModel(GameViewModel game, int rowNumber, PlayerOptionsViewModel options)
        {
            this.Game = game;
            this.rowNumber = rowNumber;
            this.Options = options;
        }
    }
}
