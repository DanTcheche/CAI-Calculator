using Calculadora.Classes.Strategies;
using Calculator.Classes.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{

    public class ValueCalculator
    {
        private ICalculatorStrategy _strategy;

        public void SetStrategy(ICalculatorStrategy strategy)
        {
            this._strategy = strategy;
        }

        public double CalculateResult(double firstNumber, string operatorValue, double secondNumber)
        {
            List<double> numeros = new List<double>();
            numeros.Add(firstNumber);
            numeros.Add(secondNumber);
            if(operatorValue == "+") {
                this.SetStrategy(new CalculatorAdd());                
            } else if (operatorValue == "-") {
                this.SetStrategy(new CalculatorSubtract());
            } else if (operatorValue == "%") {
                this.SetStrategy(new CalculatorDivide());
            } else {
                this.SetStrategy(new CalculatorMultiply());
            }
            return this._strategy.Calculate(numeros);
        }
    }
}
