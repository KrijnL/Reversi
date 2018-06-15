using Model.Reversi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel model =  new MainViewModel();
            this.DataContext = model;
        }


        

    }
    /*
    public class Navigator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Object currentScreen;

        public Navigator()
        {
            this.CurrentPage = new ScreenGame(this);

        }

        public Object CurrentPage
        {
            get
            {
                return currentScreen;
            }
            set
            {
                this.currentScreen = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentPage)));
            }
        }


    }

    public abstract class Screen
    {
        protected readonly Navigator navigator;

        protected Screen(Navigator navigator)
        {
            this.navigator = navigator;
        }

        protected void SwitchTo(Screen screen)
        {
            this.navigator.CurrentPage = screen;
        }
    }

    public class ScreenWelcome : Screen
    {
        public ScreenWelcome(Navigator navigator) : base(navigator)
        {
            GoToGame = new EasyCommand(() => SwitchTo(new ScreenGame(navigator)));
        }

        public ICommand GoToGame { get; }
    }

    public class ScreenGame : Screen
    {
        public ScreenGame(Navigator navigator) : base(navigator)
        {
            GoToWelcome = new EasyCommand(() => SwitchTo(new ScreenWelcome(navigator)));
        }

        public ICommand GoToWelcome { get; }
    }*/
}
