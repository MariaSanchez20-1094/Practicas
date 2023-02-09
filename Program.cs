using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int dinero = 0;
            int cantidad = 0;
            List<int> lista = new List<int> { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };

            do
            {
                Console.Write("Por favor Digite la nota: ");
                dinero = int.Parse(Console.ReadLine());


                if (dinero < 0)
                {
                    Console.Write("\nError: Número negativo...\n");
                }

            } while (dinero < 0);


            foreach (var item in lista)
            {
                if (dinero <= 0) break;

                if ((dinero / item) > 0)
                {
                    cantidad = dinero / item > 0 ? (dinero / item) : 0;
                    Console.Write($"\nCantidad de {item}: {cantidad} ");
                    dinero = dinero - (item * cantidad);
                }
            }

            Console.ReadKey();

        }
    }
}