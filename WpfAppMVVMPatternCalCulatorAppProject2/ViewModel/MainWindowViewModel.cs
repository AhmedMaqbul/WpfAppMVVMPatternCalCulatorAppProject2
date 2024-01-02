using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppMVVMPatternCalculatorAppProject2.Commands;
using WpfAppMVVMPatternCalculatorAppProject2.Model;

namespace WpfAppMVVMPatternCalculatorAppProject2.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel() 
        {
            //AddCommand = new AdditionCommand(this);
            //SubtractCommand = new SubtractionCommand(this);
            //MultiplyCommand = new MultiplicationCommand(this);
            //DivideCommand = new DivisionCommand(this);

            AddAction = new ActionCommand(CanAdd,Add);

            SubtractionAction = new ActionCommand(CanSubtract, Subtract);

            MultiplyAction = new ActionCommand(CanMultiply, Multiply);

            DivideAction = new ActionCommand(CanDivide, Divide);


        }
        //public ICommand AddCommand { get; set; }
        //public ICommand SubtractCommand { get; set; }
        //public ICommand MultiplyCommand { get; set; }
        //public ICommand DivideCommand { get; set; }

        public ICommand AddAction { get; set; }
        public ICommand SubtractionAction { get; set; }
        public ICommand MultiplyAction { get; set; }
        public ICommand DivideAction { get; set; }


        public Calculator MyCalculator { get; set; } = new Calculator();

        public void Add(object parameter = null)
        {
            MyCalculator.Result = MyCalculator.Addition(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }

        public bool CanAdd(object parameter = null)
        {
            return true;
        }

        public void Subtract(object parameter = null)
        {
            MyCalculator.Result = MyCalculator.Subtract(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }
        public bool CanSubtract(object parameter = null)
        {
            return true;
        }

        public void Multiply(object parameter = null)
        {
            MyCalculator.Result = MyCalculator.Multiply(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }
        public bool CanMultiply(object parameter = null )
        {
            return true;
        }

        public void Divide(object parameter = null)
        {
            MyCalculator.Result = MyCalculator.Divide(MyCalculator.FirstNumber, MyCalculator.SecondNumber);
        }
        public bool CanDivide(object parameter = null)
        {
            return true;
        }
    }
}
