using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Interactor
    {
        public static string AskMenuOption()
        {
            string selectedOption = null;
            while (selectedOption == null)
            {
                selectedOption = Console.ReadLine().ToUpper();
            }
            return selectedOption;
        }

        public static double AskDouble(string mensaje)
        {
            string enteredValue = "";
            double enteredNumber = -100000;
            bool isCorrectValue = false;

            while (!isCorrectValue || enteredNumber == -100000)
            {
                Console.WriteLine($"{mensaje}");
                enteredValue = Console.ReadLine();
                isCorrectValue = Double.TryParse(enteredValue, out enteredNumber);
            }
            return enteredNumber;
        }

        public static string AskOperator(string mensaje)
        {
            string enteredValue = "";
            bool isCorrectValue = false;
            string[] acceptedValues = { "+", "-", "%", "*" };

            while (!isCorrectValue || enteredValue == "")
            {
                Console.WriteLine($"{mensaje}");
                enteredValue = Console.ReadLine();
                isCorrectValue = acceptedValues.Contains(enteredValue);
            }
            return enteredValue;
        }
    }
}
