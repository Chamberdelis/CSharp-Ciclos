using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //  Hacer un programa que solicite el ingreso de 10 números
            //y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int
                mayor = 0,
                n1 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el numero: ");
                n1 = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = n1;
                }
                else if (n1 > mayor)
                {
                    mayor = n1; 
                }
            }

            Console.WriteLine("El mayor es: " + mayor);
        }
    }
}
