using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{
    public class Interactor
    {
        public static string PedirOpcionMenu()
        {
            string opcionIngresada = null;
            while (opcionIngresada == null)
            {
                opcionIngresada = Console.ReadLine().ToUpper();
            }
            return opcionIngresada;
        }

        public static double PedirDouble(string mensaje)
        {
            string valorIngresado = "";
            double numeroIngresado = -100000;
            bool valorCorrecto = false;

            while (!valorCorrecto || numeroIngresado == -100000)
            {
                Console.WriteLine($"{mensaje}");
                valorIngresado = Console.ReadLine();
                valorCorrecto = Double.TryParse(valorIngresado, out numeroIngresado);
            }
            return numeroIngresado;
        }

        public static string PedirOperador(string mensaje)
        {
            string valorIngresado = "";
            bool valorCorrecto = false;
            string[] valoresAceptados = { "+", "-", "%", "*" };

            while (!valorCorrecto || valorIngresado == "")
            {
                Console.WriteLine($"{mensaje}");
                valorIngresado = Console.ReadLine();
                valorCorrecto = valoresAceptados.Contains(valorIngresado);
            }
            return valorIngresado;
        }
    }
}
