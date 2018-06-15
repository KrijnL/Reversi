using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MediaPlayer mplayer;

        protected override void OnStartup(StartupEventArgs e)
        {


            base.OnStartup(e);
            
            var main = new MainWindow();
            MainViewModel mainVM = new MainViewModel();
            main.DataContext = mainVM;
            main.Show();
            mainVM.ApplicationExit += () =>
            {
                MainViewModel_ApplicationExit();
            };
            
        }

        private void MainViewModel_ApplicationExit() {
            Application.Current.Shutdown();
        }
    }
}
