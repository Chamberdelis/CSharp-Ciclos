using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            //Se pide determinar e informar:
            // El número de grupo con min porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de min a menor.
            // Opcional: Buscar el ultimo n° primo de cada grupo y marcar su posicion.
            int
                valorlista = 0,
                mayorporimp = 0,
                cantimp,
                cantxlista,
                porcen,
                n1,
                contadororden = 0,
                min;
            bool banord;
            // PUNTO C
            int
                ultprim,
                pos,
                posprim,
                contprim;
            // --------------

            for (int i = 0; i < 2; i++)
            {
                cantimp = 0;
                cantxlista = 0;
                porcen = 0;
                banord = false;

                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());

                min = n1;
                //Punto C
                ultprim = 0;
                pos = 0;
                posprim = 0;
                
                
                //------------
                while (n1 != 0)
                {
                    cantxlista++;
                    // PUNTO C
                    pos++;

                    contprim = 0;
                    //----------

                    if (n1 % 2 != 0)
                    {
                        cantimp++;
                    }

                    if (n1 <= min)
                    {
                        min = n1;
                    }
                    else
                    {
                        banord = true;
                    }
                    
                    // PUNTO C
                    for (int x = 1; x <= n1; x++)
                    {
                        if (n1 % x == 0)
                        {
                            contprim++;
                        }
                    }

                    if (contprim == 2)
                    {
                        ultprim = n1;
                        posprim = pos;
                    }
                    // ------------------------
                    Console.WriteLine("Ingrese un numero: ");
                    n1 = int.Parse(Console.ReadLine());
                    
                }  // AQUI FINALIZA EL WHILE

                if (banord == false)
                {
                    contadororden++;
                }
                porcen = (cantimp * 100) / cantxlista;

                if (porcen > mayorporimp)
                {
                    mayorporimp = porcen;
                    valorlista = i;
                }
                // PUNTO C
                if (ultprim != 0)
                {
                    Console
                        .WriteLine(" El ultimo numero primo del grupo " +
                        i +
                        " es: " +
                        ultprim +
                        " en la posicion: " +
                        posprim);
                }
                else
                {
                    Console.WriteLine("No hay numeros primos.");
                }

                // ----------------------
                
            }

            Console
                .WriteLine("El min grupo con porcentaje de impares es: " +
                "Grupo N°: " +
                valorlista +
                " con un " +
                mayorporimp +
                "%");

            if (contadororden >= 1)
            {
                Console
                    .WriteLine("La cantidad de grupos cuyos numeros estan ordenados de Mayor a Menor es: " +
                    contadororden);
            }
        }
    }
}
