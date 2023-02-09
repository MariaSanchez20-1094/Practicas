using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            int i = 1;

            while (i <= n)
            {
                f *= i;
                i++;
            }

            return f;
        }

        static int CombinacionesSinRepeticion(int n, int p)
        {
            int FactorialN = Factorial(n);
            int FactorialP = Factorial(p);
            int FactorialNP = Factorial(n - p);

            return FactorialN / (FactorialP * FactorialNP);
        }



        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1. Combinaciones sin repeticion");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    int a;
                    int b;

                    Console.WriteLine("Inserta el primer numero");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserta el segundo numero");
                    b = Convert.ToInt32(Console.ReadLine());


                    int c = CombinacionesSinRepeticion(a, b);
                    Console.WriteLine(c);
                    Console.Read();



                    break;

            }

        }
    }
}
