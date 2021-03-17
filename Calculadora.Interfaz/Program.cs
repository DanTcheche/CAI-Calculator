using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorSalir = "X";
            string opcionIngresada = null;
            while (opcionIngresada != valorSalir)
            {
                MostrarMenu();
                opcionIngresada = PedirOpcionMenu();
                if (opcionIngresada == 1)
                {
                    AgregarArticulo(codigoArticulo, descripcion, precio, articulosIngresados, maximoArticulos);
                    articulosIngresados++;
                }
                else if (opcionIngresada == 2)
                {
                    ListarArticulos(codigoArticulo, descripcion, precio, articulosIngresados);
                }
                else if (opcionIngresada == valorSalir)
                {
                    break;
                }

            }
        }
    }
}
