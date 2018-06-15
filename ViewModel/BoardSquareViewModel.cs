﻿
using Cell;
using DataStructures;
using Model.Reversi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class BoardSquareViewModel : INotifyPropertyChanged 
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public Cell<string> Owner {get;set;}

        public GameViewModel Game { get; set; }
        public Vector2D Position { get; set; }
        public ICommand PutStone { get; set; }
        public Cell<bool> Valid { get; set; }


        public BoardSquareViewModel(GameViewModel game, Vector2D position)
        {
            this.Game = game;
            this.Position = position;
            this.PutStone = new PutStoneCommand(Game, Position);
            if (Game.Board[Position] != null)
                this.Owner = Cell.Cell.Create(Game.Board[Position].ToString());
            else
                this.Owner = Cell.Cell.Create("");
            this.Valid = Cell.Cell.Create(Game.IsValidMove(Position));
            Game.PropertyChanged += (s, e) =>
            {
                Refresh();
            };
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Refresh()
        {
            this.Owner.Value = Game.Board[Position] != null ? Game.Board[Position].ToString() : "";
            this.Valid.Value = Game.IsValidMove(Position);
        }


    }
}
