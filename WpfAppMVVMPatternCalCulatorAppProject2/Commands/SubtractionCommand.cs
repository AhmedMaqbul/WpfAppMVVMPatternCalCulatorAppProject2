using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVMPatternCalculatorAppProject2.Commands;
using WpfAppMVVMPatternCalculatorAppProject2.ViewModel;

namespace WpfAppMVVMPatternCalculatorAppProject2.Commands
{
    public class SubtractionCommand : RelayCommand
    {
        private MainWindowViewModel _subtract;
        public SubtractionCommand(MainWindowViewModel subtract)
        {
            _subtract = subtract;
        }

        public override bool CanExecute(object parameter)
        {
            return _subtract.CanSubtract();
        }

        public override void Execute(object parameter)
        {
            _subtract.Subtract();
        }
    }
}
