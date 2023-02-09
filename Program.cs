using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double tiempo;
            double distacia;
            double velocidad;

            Console.Write("Calculo de Area geometricas, Por Favor selecione la opcion");
            Console.Write("\n1 - Velocidad");
            Console.Write("\n2 - Tiempo");
            Console.Write("\n3 - Distacia\n");


            do
            {

                do
                {
                    Console.Write("Por favor Digite la opcion: ");
                    opcion = int.Parse(Console.ReadLine());


                    if (opcion < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (opcion < 0);

                switch (opcion)
                {
                    case 1:

                        do
                        {
                            Console.Write("Por favor Digite la distacia: ");
                            distacia = double.Parse(Console.ReadLine());


                            if (distacia < 0)
                            {
                                Console.Write("\nError: Número negativo...\n");
                            }

                        } while (distacia < 0);


                        do
                        {
                            Console.Write("Por favor Digite el tiempo: ");
                            tiempo = double.Parse(Console.ReadLine());


                            if (opcion < 0)
                            {
                                Console.Write("\nError: Número negativo...\n");
                            }

                        } while (opcion < 0);
                        Console.Write($"\nLa velocidad es: {distacia / tiempo}");

                        break;

                    case 2:

                        do
                        {
                            Console.Write("Por favor Digite la distacia: ");
                            distacia = double.Parse(Console.ReadLine());


                            if (distacia < 0)
                            {
                                Console.Write("\nError: Número negativo...\n");
                            }

                        } while (distacia < 0);


                        do
                        {
                            Console.Write("Por favor Digite el velocidad: ");
                            velocidad = double.Parse(Console.ReadLine());


                            if (velocidad < 0)
                            {
                                Console.Write("\nError: Número negativo...\n");
                            }

                        } while (velocidad < 0);
                        Console.Write($"\nEl Tiempo es: {distacia / velocidad}");
                        break;

                    case 3:

                        do
                        {
                            Console.Write("Por favor Digite la Tiempo: ");
                            tiempo = double.Parse(Console.ReadLine());


                            if (tiempo < 0)
                            {
                                Console.Write("\nError: Número negativo...\n");
                            }

                        } while (tiempo < 0);


                        do
                        {
                            Console.Write("Por favor Digite el velocidad: ");
                            velocidad = double.Parse(Console.ReadLine());


                            if (velocidad < 0)
                            {
                                Console.Write("\nError: Número negativo...\n");
                            }

                        } while (velocidad < 0);
                        Console.Write($"\nEl Tiempo es: {tiempo * velocidad}");
                        break;
                }

                if (opcion < 1 || opcion > 3)
                {
                    Console.Write("\nError: No existe esa opción...\n");
                }

            } while (opcion < 1 || opcion > 3);

            Console.ReadKey();
        }
    }
}
