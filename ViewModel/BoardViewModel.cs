using Model.Reversi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BoardViewModel : INotifyPropertyChanged
    {
        //private ReversiBoard board;
        private GameViewModel game;

        public event PropertyChangedEventHandler PropertyChanged;

        public PlayerOptionsViewModel Options { get; set; }

        public List<BoardRowViewModel> Rows
        {
            get
            {
                List<BoardRowViewModel> rows = new List<BoardRowViewModel>();
                for(int i = 0; i<Game.Board.Height; i++)
                {
                    rows.Add(new BoardRowViewModel(Game, i , Options));
                }
                return rows;
            }
        }


        public GameViewModel Game
        {
            get { return game; }
            set
            {
                game = value;
            }
        }

        public BoardViewModel(GameViewModel game, PlayerOptionsViewModel options)
        {
           this.Game = game;
            this.Options = options;
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
