using Calculadora.Classes.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Strategies
{
    public class CalculatorSubtract : ICalculatorStrategy
    {
        public double Calculate(List<double> data)
        {
            List<double> numbers = data as List<double>;
            double result = numbers[0];
            for (var i = 1; i < numbers.Count; i++)
            {
                result -= numbers[i];                
            }
            return result;
        }
    }
}
