using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer un programa para ingresar 10 números.
            //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            int
                n1,
                contador,
                contadorPrimos = 0;
            bool banuno;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Seleccione un numero para analizar: ");
                n1 = int.Parse(Console.ReadLine());

                contador = 0;
                banuno = false;

                for (int x = 1; x <= n1; x++)
                {
                    if (n1 == 1)
                    {
                        banuno = true;
                    }
                    else if (n1 % x == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2 || banuno == true)
                {
                    contadorPrimos ++;
                    Console.WriteLine(n1 + " Es primo");
                }
                else
                {
                    Console.WriteLine(n1 + " NO ES primo");
                }
            }
            Console.WriteLine("La cantidad de numeros primos es: "+ contadorPrimos);
        }
    }
}
