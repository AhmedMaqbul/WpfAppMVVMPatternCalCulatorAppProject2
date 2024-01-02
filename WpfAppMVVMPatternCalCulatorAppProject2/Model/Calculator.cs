using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVMPatternCalculatorAppProject2.Model
{
    public class Calculator : INotifyPropertyChanged
    {
        private double _firstNumber;
        private double _secondNumber;
        private double _result;

        public double FirstNumber
        {
            get => _firstNumber;
            set
            {
                _firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        public double SecondNumber
        {
            get => _secondNumber;

            set
            {
                _secondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }

        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Addition(double firstValue, double secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber + SecondNumber;
            return Result;
        }

        public double Subtract(double firstValue, double secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber - SecondNumber;
            return Result;
        }

        public double Multiply(double firstValue, double secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;

            Result = FirstNumber * SecondNumber;
            return Result;
        }

        public double Divide(double firstValue, double secondValue)
        {
            this.FirstNumber = firstValue;
            this.SecondNumber = secondValue;
            //if (this.SecondNumber == 0)
            //{
            //  throw new ArgumentException("Undefined");
            //}

            Result = FirstNumber / SecondNumber;
            return Result;
        }
    }
}
