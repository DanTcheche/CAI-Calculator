using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes.Strategies { 
    public interface ICalculatorStrategy
    { 
        double Calculate(List<double> data);
    }
}
