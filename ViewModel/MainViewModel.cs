using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Screen currentScreen;

        public event Action ApplicationExit;

        public Screen CurrentScreen
        {
            get
            {
                return this.currentScreen;
            }
            set
            {
                this.currentScreen = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentScreen)));
            }
        }

        public MainViewModel()
        {
            this.CurrentScreen = new WelcomeViewModel(this);
        }

        public void Exit()
        {
            ApplicationExit?.Invoke();
        }

        
    }

    public abstract class Screen
    {
        protected readonly MainViewModel viewModel;

        protected Screen(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        protected void SwitchTo(Screen screen)
        {
            this.viewModel.CurrentScreen = screen;
        }
    }

    public class ScreenWelcome : Screen
    {
        public ScreenWelcome(MainViewModel navigator) : base(navigator)
        {
            GoToGame = new EasyCommand(() => SwitchTo(new ScreenGame(navigator)));
        }

        public ICommand GoToGame { get; }
    }

    public class ScreenGame : Screen
    {
        public ScreenGame(MainViewModel navigator) : base(navigator)
        {
            GoToWelcome = new EasyCommand(() => SwitchTo(new ScreenWelcome(navigator)));
        }

        public ICommand GoToWelcome { get; }
    }
}
