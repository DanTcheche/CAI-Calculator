using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{
    public class Calculador
    {
        public static double CalcularResultado(double primerNumero, string operador, double segundoNumero)
        {
            if(operador == "+") {
                return primerNumero + segundoNumero;
            } else if (operador == "-") {
                return primerNumero - segundoNumero;
            } else if (operador == "%") {
                return primerNumero / segundoNumero;
            } else {
                return primerNumero * segundoNumero;
            }
        }
    }
}
