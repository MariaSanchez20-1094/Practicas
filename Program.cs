using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double ejercicio1;
            double ejercicio2;

            Console.Write("Calculo de Area geometricas, selecione la opcion");
            Console.Write("\n1 - Cubo");
            Console.Write("\n2 - Esfera");
            Console.Write("\n3 - Cono");
            Console.Write("\n4 - Pirámide");

            do
            {
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    cs 1: 
                        do
                {
                    Console.Write("Por favor Digite la longitud de uno de los lados: ");
                    dato1 = double.Parse(Console.ReadLine());


                    if (dato1 < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (ejercicio1 < 0);

                Console.Write($"\nResultado: {Math.Pow(dato1, 3)}");
                break;

                cs 2:
                        do
                {
                    Console.Write("Por favor Digite el radio de la Esfera: ");
                    dato1 = double.Parse(Console.ReadLine());


                    if (ejercicio1 < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (ejercicio1 < 0);

                Console.Write($"\nResultado: {4 / 3 * Math.PI * (Math.Pow(dato1, 3))}");
                break;

                cs 3:
                        do
                {
                    Console.Write("Por favor Digite la radio del Cono: ");
                    ejercicio1 = double.Parse(Console.ReadLine());


                    if (ejercicio1 < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (ejercicio1 < 0);

                do
                {
                    Console.Write("Por favor Digite la altura del Cono: ");
                    ejercicio2 = double.Parse(Console.ReadLine());


                    if (ejercicio2 < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (ejercicio2 < 0);

                Console.Write($"\nResultado: {(Math.PI * Math.Pow(dato1, 2) * dato2) / 3}");
                break;

                cs 4:
                        do
                {
                    Console.Write("Por favor Digite  la altura de la Piramide: ");
                    ejercicio1 = double.Parse(Console.ReadLine());


                    if (ejercicio1 < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (ejercicio1 < 0);

                do
                {
                    Console.Write("Por favor Digite la longitud de uno de los lado de la Piramide: ");
                    ejercicicio2 = double.Parse(Console.ReadLine());


                    if (dato2 < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (dato2 < 0);

                Console.Write($"\nResultado: {(ejercicio1 * ejercicio2 * ejercicio2) / 3}");
                break;
            }

                if (opcion < 1 || opcion > 4)
            {
                Console.Write("\nError: *****No existe esa opción****\n");
            }

        } while (opcion< 1 || opcion> 4);

            Console.ReadKey();
        }
}
}