using Model.Reversi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View;

namespace ViewModel
{
    public class GameOverViewModel : Screen
    {

        public ICommand Exit { get; }
        public ICommand Restart { get; }

        public PlayerOptionsViewModel Options { get; }

        public PlayerViewModel Winner { get; set; }

        public GameOverViewModel(MainViewModel model, PlayerOptionsViewModel options, PlayerViewModel winner) : base(model)
        {
            this.Options = options;
            this.Winner = winner;
            Exit = new ExitCommand(this.viewModel);

            Restart = new EasyCommand(() =>
           {
               WelcomeViewModel newGame = new WelcomeViewModel(this.viewModel);
               newGame.Options = Options;
               SwitchTo(newGame);
           });
        }

        public class ExitCommand : ICommand
        {
            private MainViewModel model;
            public ExitCommand(MainViewModel model)
            {
                this.model = model;
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                model.Exit();
            }
        }
    }
}
