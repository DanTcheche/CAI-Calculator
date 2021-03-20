using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{
    public class CaluladorRestar : IEstrategiaCaluladora
    {
        public double Ejecutar(List<double> data)
        {
            List<double> numeros = data as List<double>;
            double resultado = 0;
            for (var i = 0; i < numeros.Count; i++)
            {
                if(i==0)
                {
                    resultado += numeros[i];
                } else
                {
                    resultado -= numeros[i];
                }
                
            }
            return resultado;
        }
    }
}
