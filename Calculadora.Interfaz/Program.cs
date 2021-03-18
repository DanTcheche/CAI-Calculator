﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.LibreriaDeClases;

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
                Console.WriteLine("Para salir ingrese X o cualquier otra cosa para continuar");
                opcionIngresada = Interactor.PedirOpcionMenu().ToUpper();
                Console.WriteLine(opcionIngresada);
                int primerNumero = Interactor.PedirInt("Ingrese el primer digito.");
                string operador = Interactor.PedirOperador("Ingrese un operador (-, +, % o *)"); 
                int segundoNumero = Interactor.PedirInt("Ingrese el primer digito.");
                float resultado = Calculador.CalcularResultado(primerNumero, operador, segundoNumero);
                Console.WriteLine($"El resultado es: {resultado}");
            }
        }
    }
}
