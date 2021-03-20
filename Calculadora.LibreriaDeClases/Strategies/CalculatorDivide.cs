using Calculadora.Classes.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Strategies
{
    public class CalculatorDivide : ICalculatorStrategy
    {
        public double Calculate(List<double> data)
        {
            List<double> numbers = data as List<double>;
            double result = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    result += numbers[i];
                }
                else
                {
                    if (numbers[i] == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result /= numbers[i];                 
                }
            }
            return result;
        }
    }
}
