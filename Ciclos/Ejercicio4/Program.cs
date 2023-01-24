using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.

            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            int
                n1,
                cont = 0;

            Console.WriteLine("Ingrese el numero a evaluar: ");
            n1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero NO ES primo");
            }
        }
    }
}
