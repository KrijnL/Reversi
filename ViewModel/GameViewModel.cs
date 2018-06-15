using Cell;
using DataStructures;
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
    public class GameViewModel : Screen, INotifyPropertyChanged 
    {

        private ReversiGame game;
        private Player currentPlayer;

        public event PropertyChangedEventHandler PropertyChanged;

        public ReversiGame Game
        {
            get { return game; }
            set { game = value; NotifyPropertyChanged(); }
        }
        public ReversiBoard Board { get; set; }
        public BoardViewModel BoardVM { get; set; }
        public Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }

            set
            {
                this.currentPlayer = value;
                NotifyPropertyChanged(nameof(CurrentPlayer));
            }
        }

        public PlayerViewModel PlayerW { get; set; }
        public PlayerViewModel PlayerB { get; set; }
        

        public GameViewModel(MainViewModel viewModel, int width, int height) : base(viewModel)
        {
            this.Game = new ReversiGame(width,height);
            this.BoardVM = new BoardViewModel(this);
            this.Board = Game.Board;
            this.CurrentPlayer = Game.CurrentPlayer;
            
        }

        public void PutStone(Vector2D position)
        {
            this.Game = Game.PutStone(position);
            this.Board = Game.Board;
            this.CurrentPlayer = Game.CurrentPlayer;
        }

        public bool IsValidMove(Vector2D position)
        {
            return Game.IsValidMove(position);
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
