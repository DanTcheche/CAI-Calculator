using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{
    public class CalculadorSumar : IEstrategiaCaluladora
    {
        public double Ejecutar(List<double> data)
        {
            List<double> numeros = data as List<double>;
            double resultado = 0;
            foreach (double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
    }
}
