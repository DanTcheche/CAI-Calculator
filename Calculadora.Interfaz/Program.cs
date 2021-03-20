using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Classes;
using Calculator.Classes;

namespace Calculadora.Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitValue = "X";
            string enteredValue = null;
            double result = 0;
            ValueCalculator calculator = new ValueCalculator();
            while (enteredValue != exitValue)
            {
                double firstNumber = Interactor.AskDouble("Enter the first number:");
                string operatorValue = Interactor.AskOperator("Ingrese un operador (-, +, % o *)");
                double secondNumber = Interactor.AskDouble("Enter the second number:");    
                try
                {
                    result = calculator.CalculateResult(firstNumber, operatorValue, secondNumber);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by 0.");
                    continue;
                }
                Console.WriteLine($"The result is: {result}");
                Console.WriteLine("To exit type X or type any other thing to continue.");
                enteredValue = Interactor.AskMenuOption().ToUpper();
            }
        }
    }
}
