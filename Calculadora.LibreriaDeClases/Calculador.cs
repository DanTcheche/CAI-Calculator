using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{
    public class Calculador
    {
        public static float CalcularResultado(int primerNumero, string operador, int segundoNumero)
        {
            if(operador == "+") {
                return primerNumero + segundoNumero;
            } else if (operador == "-") {
                return primerNumero - segundoNumero;
            } else if (operador == "%") {
                return primerNumero % segundoNumero;
            } else {
                return primerNumero * segundoNumero;
            }
        }
    }
}
