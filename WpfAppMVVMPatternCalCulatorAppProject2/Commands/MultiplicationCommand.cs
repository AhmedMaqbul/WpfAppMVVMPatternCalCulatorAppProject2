using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorAppProject2.Commands;
using WpfAppMVVMPatternCalculatorAppProject2.ViewModel;

namespace WpfAppMVVMPatternCalculatorAppProject2.Commands
{
    public class MultiplicationCommand : RelayCommand
    {
        private MainWindowViewModel _multiply;
        public MultiplicationCommand(MainWindowViewModel multiply)
        {
            _multiply = multiply;
        }

        public override bool CanExecute(object parameter)
        {
            return _multiply.CanMultiply();
        }

        public override void Execute(object parameter)
        {
            _multiply.Multiply();
        }
    }
}
