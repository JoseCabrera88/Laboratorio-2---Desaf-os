//Crear un método static, que pida dos valores de entrada, los cuales debe convertir a entero y sumarlos, este método debe estar en un bloque
//Try-Catch-Finally y mostrar un mensaje de Error si sucede algún fallo durante la ejecución (por ejemplo si el valor introducido es un texto
//en lugar de un número o sí el valor introducido esta en blanco).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Programa3
    {
        static void Main(string[] args)
        {
            ConvertirAEnteros();
        }

        static void ConvertirAEnteros()
        {
            Console.WriteLine("Escriba 2 números:");
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int total = n1 + n2;

                Console.WriteLine("El resultado es: {0}", total);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocurrio un error.");
            }
            finally 
            {
                Console.WriteLine("Fin del Programa.");
            }
            Console.ReadKey();
        }
    }
}
