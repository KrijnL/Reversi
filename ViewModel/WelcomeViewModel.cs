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
    public class WelcomeViewModel : Screen
    {
        private int width;
        private int height;
        public int Width
        {
            get { return width; }
            set
            {
                if (ReversiBoard.IsValidWidth(value))
                    this.width = value;
            }
        }

        public int Height {
            get { return height; }
            set
            {
                if (ReversiBoard.IsValidHeight(value))
                    this.height = value;
            }
        }        

        

        public PlayerOptionsViewModel Options { get; set;}


        public WelcomeViewModel(MainViewModel viewModel) : base(viewModel)
        {
            this.Width = 8;
            this.Height = 8;

            this.Options = new PlayerOptionsViewModel();
            
            StartGame = new EasyCommand(() => {
                
                SwitchTo(new GameViewModel(this.viewModel, Width, Height, Options));
                });
        }

        public ICommand StartGame { get; }

    }
}
