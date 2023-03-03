//Crea un sistema de inicio de sesión de usuario, donde el usuario puede primero registrarse y luego iniciar sesión. El programa debe verificar
//si el usuario ha ingresado el nombre de usuario y la contraseña correctos al iniciar sesión (por lo tanto, los mismos que utilizó al registrarse).
//Utiliza declaraciones If, ingresos del usuario y métodos para resolver el desafío.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    internal class Programa4
    {
        static string usuario = "";
        static string contrasena = "";
        static void Main(string[] args)
        {
            Registrar();
            IniciarSesion();
            Console.ReadKey();
        }

        static void Registrar() 
        {
            Console.WriteLine("REGISTRO: Ingrese su nombre de Usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("REGISTRO: Ingrese la contrasenia de su Usuario: ");
            contrasena = Console.ReadLine();
        }

        static void IniciarSesion() 
        {
            Console.WriteLine("LOGIN: Ingrese su nombre de Usuario: ");
            string usuarioingresado = Console.ReadLine();
            Console.WriteLine("LOGIN: Ingrese la contrasenia de su Usuario: ");
            string contrasenaingresada = Console.ReadLine();

            if (usuario.ToLower().Equals(usuarioingresado.ToLower())) 
            {
                if (contrasena.Equals(contrasenaingresada)) 
                {
                    Console.WriteLine("Bienvenido {0}", usuarioingresado);
                }
            }
            else 
            {
                Console.WriteLine("La contraseña que ingresó es invalida.");
            }
        }
    }
}
