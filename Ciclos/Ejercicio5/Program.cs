using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hacer un programa que solicite 20 números y

            //luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            // "Hago de 5, me da paja poner 20 valores"
            int
                n1,
                maxpar = 0,
                minimpar = 0;
            bool
                banPar = false,
                banImpar = false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero: ");
                n1 = int.Parse(Console.ReadLine());

                if (n1 % 2 == 0)
                {
                    if (banPar == false)
                    {
                        maxpar = n1;
                        banPar = true;
                    }
                    else if (n1 > maxpar)
                    {
                        maxpar = n1;
                    }
                }
                else
                {
                    if (banImpar == false)
                    {
                        minimpar = n1;
                        banImpar = true;
                    }
                    else if (n1 < minimpar)
                    {
                        minimpar = n1;
                    }
                }
            }

            Console
                .WriteLine("El maximo par es: " +
                maxpar +
                " Y el minimo impar es: " +
                minimpar);
        }
    }
}
