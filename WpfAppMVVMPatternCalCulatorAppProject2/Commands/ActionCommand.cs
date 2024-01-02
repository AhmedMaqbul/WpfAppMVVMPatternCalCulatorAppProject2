using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorAppProject2.Commands;
using WpfAppMVVMPatternCalculatorAppProject2.ViewModel;

namespace WpfAppMVVMPatternCalculatorAppProject2.Commands
{
    public class ActionCommand : RelayCommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;
        public ActionCommand(Func<object,bool> canExecuteDelegate, Action<object> executeDelegate)
        {
            _canExecute = canExecuteDelegate;
            _execute = executeDelegate;
        }

        public override bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public override void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
