﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp21.Model;

namespace WpfApp21
{
    internal class DelegateCommand : ICommand
    {
        private Action<object> execute;
        public DelegateCommand(Action<object> executeAction)
        {
            execute = executeAction;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
