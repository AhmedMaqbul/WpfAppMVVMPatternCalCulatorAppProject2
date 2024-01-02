using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorAppProject2.Commands;
using WpfAppMVVMPatternCalculatorAppProject2.ViewModel;

namespace WpfAppMVVMPatternCalculatorAppProject2.Commands
{
    public class DivisionCommand : RelayCommand
    {
        private MainWindowViewModel _division;
        public DivisionCommand(MainWindowViewModel division)
        {
            _division = division;
        }

        public override bool CanExecute(object parameter)
        {
            return _division.CanDivide();
        }

        public override void Execute(object parameter)
        {
            _division.Divide();
        }
    }
}
