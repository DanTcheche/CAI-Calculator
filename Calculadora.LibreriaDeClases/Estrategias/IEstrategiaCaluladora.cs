using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.LibreriaDeClases
{
    public interface IEstrategiaCaluladora
    {
        double Ejecutar(List<double> data);
    }
}
