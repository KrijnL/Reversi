using DataStructures;
using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class PutStoneCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private GameViewModel Game;
        private Vector2D position;

        public PutStoneCommand(GameViewModel game, Vector2D position)
        {
            this.Game = game;
            this.position = position;
            Game.PropertyChanged += (s, e) =>
            {
                CanExecuteChanged?.Invoke(this, new EventArgs());
            };
        }

        public bool CanExecute(object parameter)
        {
            if (Game.IsValidMove(position))
                return true;
            return false;
        }

        public void Execute(object parameter)
        {
            Game.PutStone(position);

        }
    }
}
