using Calculadora.Classes.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Strategies
{
    public class CalculatorMultiply : ICalculatorStrategy
    {
        public double Calculate(List<double> data)
        {
            List<double> numbers = data as List<double>;
            double result = 1;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }
    }
}
