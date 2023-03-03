//Crea una aplicación que maneje los puntajes de un juego imaginario. Tendrá un puntaje, un puntaje record y un jugador record.
//Crea un método que tenga dos parámetros, uno para el puntaje obtenido y otro para el nombre del jugador. Cuando se llama a ese método, se debe verificar
//si el puntaje del jugador es mayor que la puntuación más alta, si es así, que se escriba en la consola algo así como"La nueva puntuación más alta es " + puntuación.
//Y en otra línea "La puntuación más alta fue lograda por " + nombre del jugador. Si no fue así, entonces que se escriba algo como "La puntuación más alta de
//" + puntuación más alta + " no se ha podido superar, y aún está en manos de " + jugador record. Considera qué variables se requieren globalmente y cuáles localmente.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    internal class Programa5
    {
        static int puntuacionrecord = 0;
        static string jugadorrecord = "";

        static void Main(string[] args)
        {
            puntajes(30, "Maria");
            puntajes(7, "Luis");
            puntajes(22, "Jarvin");
            puntajes(45, "Pablo");
            puntajes(100, "Alvaro");

            Console.ReadKey();
        }

        public static void puntajes(int puntaje, string nombredeljugador)
        {
            if (puntaje > puntuacionrecord)
            {
                puntuacionrecord = puntaje;
                jugadorrecord = nombredeljugador;

                Console.WriteLine("La nueva puntuacion mas alta es: {0} ", puntuacionrecord);
                Console.WriteLine("La nueva puntuacion fue obtenida por: {0} ", jugadorrecord);
            }
            else
            {
                Console.WriteLine("La puntuacion mas alta de: {0}, no se ha podido superarar y " +
                    "aun esta en manos de: {1}", puntuacionrecord, jugadorrecord);
            }
        }
    }
}
