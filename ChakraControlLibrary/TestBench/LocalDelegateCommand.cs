using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TestBench
{
    public class LocalDelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action _act;
        public LocalDelegateCommand(Action act)
        {
            _act = act;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _act();
        }
    }
}
