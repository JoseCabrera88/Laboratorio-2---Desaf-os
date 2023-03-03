//Crear una clase que contenga 4 métodos que realicen las operaciones básicas (Sumar, Restar, Multiplicar, Dividir), debe pedir como parámetro
//dos números de tipo int y retornar un valor del mismo tipo. Debe invocar los 4 métodos desde el método main.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Programa2
    {
        static void Main(string[] args)
        {
            Programa2 calculadora = new Programa2();

            int total = calculadora.Sumar(20, 5);
            int diferencia = calculadora.Restar(20, 5);
            int producto = calculadora.Multiplicar(20, 5);  
            int cociente = calculadora.Dividir(20, 5);

            Console.WriteLine("Los resultados de las operaciones son: Suma= {0}, Resta= {1}, Multiplicación= {2}, División= {3}.", total, diferencia, producto, cociente);
            Console.ReadKey();
        }

        public int Sumar(int n1, int n2) 
        {
            return n1 + n2;
        }

        public int Restar(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
