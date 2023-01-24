using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int cantlist, n, ngrupo = 0;

            
            Console.WriteLine("Ingrese un numero positivo para agregar al sublote o NEGATIVO para finalizar");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {   
                cantlist = 0;
                ngrupo++;
                while (n > 0)
                {
                    cantlist++;
                    Console.WriteLine("Ingrese un numero positivo para agregar al sublote o CERO para salir del sublote.");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("La cantidad de numeros positivos del grupo " + ngrupo + " es: " + cantlist);

                Console.WriteLine("Ingrese un numero positivo para cargar OTRO SUBLOTE o un NEGATIVO para finalizar el programa.");
                n = int.Parse(Console.ReadLine());
            
            }
        }
    }
}
