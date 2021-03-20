using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{

    public class Calculador
    {
        private IEstrategiaCaluladora _estrategia;

        public void SetStrategy(IEstrategiaCaluladora estrategia)
        {
            this._estrategia = estrategia;
        }

        public double CalcularResultado(double primerNumero, string operador, double segundoNumero)
        {
            List<double> numeros = new List<double>();
            numeros.Add(primerNumero);
            numeros.Add(segundoNumero);
            if(operador == "+") {
                this.SetStrategy(new CaluladorSumar());
                return this._estrategia.Ejecutar(numeros);
            } else if (operador == "-") {
                this.SetStrategy(new CaluladorRestar());
                return this._estrategia.Ejecutar(numeros);
            } else if (operador == "%") {
                return primerNumero / segundoNumero;
            } else {
                return primerNumero * segundoNumero;
            }
        }
    }
}
