using Calculadora.LibreriaDeClases.Estrategias;
using Calculadora.LibreriaDeClases.Interfaces;
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
                this.SetStrategy(new CalculadorSumar());                
            } else if (operador == "-") {
                this.SetStrategy(new CalculadorRestar());
            } else if (operador == "%") {
                this.SetStrategy(new CalculadorDividir());
            } else {
                this.SetStrategy(new CalculadorMultiplicar());
            }
            return this._estrategia.Ejecutar(numeros);
        }
    }
}
