using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            // " Voy a hacer de 5, una paja poner 20 edades."
            float
                promedio = 0,
                n1,
                edadtotal = 0,
                contador18 = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Seleccione las edades: ");
                n1 = float.Parse(Console.ReadLine());
                if (n1 > 18)
                {
                    edadtotal += n1;
                    contador18++;
                }

                if (i == 5)
                {
                    promedio = edadtotal / contador18;
                }
            }

            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
