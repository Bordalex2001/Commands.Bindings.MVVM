using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commands.Bindings.MVVM
{
    internal class RelayCommand
    {
        private Action<object> _execute;
        //private Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            //_canExecute = canExecute;
        }

        /*public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }*/

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
