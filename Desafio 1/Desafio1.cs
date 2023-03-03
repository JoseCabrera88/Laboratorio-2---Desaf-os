//Crear un método static, que pida los ingresos de los últimos 3 meses, así como el nombre del usuario e imprima en pantalla la suma de todos los ingresos
//y un promedio con un mensaje similiar a "Hola <usuario> en total ganaste suma y promediaste promedio ".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Programa1
    {
        static void Main(string[] args)
        {
            PromedioSalarios();
        }

        public static void PromedioSalarios()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tus salarios de los ultimos 3 meses: ");
            int salario1 = int.Parse(Console.ReadLine());
            int salario2 = int.Parse(Console.ReadLine());
            int salario3 = int.Parse(Console.ReadLine());
            int total = salario1 + salario2 + salario3;
            int promedio = total / 3;
            Console.WriteLine("Hola {0} en total ganaste {1}, y promediaste {2}.", nombre, total, promedio);
            Console.ReadKey();

        }
    }
}
