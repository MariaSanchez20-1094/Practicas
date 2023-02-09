using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double parcial1;
            double parcial2;
            double examenFinal;
            double notaPractica;
            double promedioParciales;
            double promedio;
            string si;

            do
            {
                Console.WriteLine("Bienvenido al sistema de calificaciones");
                Console.WriteLine("\nDigitar la nota del primer parcial");
                parcial1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nDigitar la nota del segundo parcial");
                parcial2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nDigitar la nota del examen final");
                examenFinal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nDigitar nota practica");
                notaPractica = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                promedioParciales = (parcial1 + parcial2) / 2;
                promedio = (promedioParciales + notaPractica + examenFinal) / 3;

                if (notaPractica <= 69 || examenFinal <= 54)
                {
                    Console.WriteLine("\nMateria reprobada");
                }
                else if (promedio >= 90)
                {
                    Console.WriteLine("\nSu nota literal es A y su promedio es de: " + Math.Round(promedio, 2));
                }
                else if (promedio >= 80)
                {
                    Console.WriteLine("\nSu nota literal es B y su promedio es de: " + Math.Round(promedio, 2));
                }
                else if (promedio >= 70)
                {
                    Console.WriteLine("\nSu nota literal es C y su promedio es de: " + Math.Round(promedio, 2));
                }
                else if (promedio >= 60)
                {
                    Console.WriteLine("\nSu nota literal es D y su promedio es de: " + Math.Round(promedio, 2));
                }
                else if (promedio >= 50)
                {
                    Console.WriteLine("\nSu nota literal es F y su promedio es de: " + Math.Round(promedio, 2));
                }


                Console.WriteLine("\nDesea volver a intentarlo? ");
                si = Console.ReadLine();
                Console.Clear();
            }

            while (si == "si" || si == "SI");
        }
    }
}
