using System;
using System.Windows.Input;

namespace View
{
    public class EasyCommand : ICommand
    {
        private readonly Action action;

        public EasyCommand(Action action)
        {
            this.action = action;
        }

        // The add { } remove { } gets rid of annoying warning
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}