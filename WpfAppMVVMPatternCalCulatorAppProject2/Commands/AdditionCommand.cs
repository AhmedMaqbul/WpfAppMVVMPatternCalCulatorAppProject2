using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorAppProject2.Commands;
using WpfAppMVVMPatternCalculatorAppProject2.ViewModel;

namespace WpfAppMVVMPatternCalculatorAppProject2.Commands
{
    public class AdditionCommand : RelayCommand
    {
        private MainWindowViewModel _addition;
        public AdditionCommand(MainWindowViewModel addition)
        {
            _addition = addition;
        }

        public override bool CanExecute(object parameter)
        {
            return _addition.CanAdd();
        }

        public override void Execute(object parameter)
        {
            _addition.Add();
        }

    }
}
