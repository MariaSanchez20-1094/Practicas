using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius;
            double kelvin;
            double fahrenheit;
            double resultado;
            int num;
            string si;

            do
            {
                Console.WriteLine("Elige una opcion de conversion");
                Console.WriteLine("1. De celsius a kelvin");
                Console.WriteLine("2. De celsius a fahrenheit ");
                Console.WriteLine("3. De kelvin a celsius");
                Console.WriteLine("4. De kelvin a fahrenheit");
                Console.WriteLine("5. De fahrenheit a celsius");
                Console.WriteLine("6. De fahrenheit a kelvin");

                num = Convert.ToInt32(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        Console.WriteLine("Favor inserte grados celsius");
                        celcius = Convert.ToDouble(Console.ReadLine());

                        resultado = (celcius + 273.15);
                        Console.WriteLine(" Grados kelvin: " + resultado);
                        break;

                    case 2:
                        Console.WriteLine("Favor inserte grados celcius");
                        celcius = Convert.ToDouble(Console.ReadLine());


                        resultado = ((celcius * 1.8) + 32);
                        Console.WriteLine("Grados fahrenheit: " + resultado);
                        break;

                    case 3:
                        Console.WriteLine("Favor inserte grados kelvin");
                        kelvin = Convert.ToDouble(Console.ReadLine());


                        resultado = (kelvin - 273.15);
                        Console.WriteLine("Grados celsius: " + resultado);
                        break;

                    case 4:
                        Console.WriteLine("Favor inserte grados kelvin");
                        kelvin = Convert.ToDouble(Console.ReadLine());


                        resultado = ((kelvin - 273.15) * 9 / 5 + 32);
                        Console.WriteLine("Grados fahrenheit: " + resultado);
                        break;

                    case 5:
                        Console.WriteLine("Favor inserte grados fahrenheit");
                        fahrenheit = Convert.ToDouble(Console.ReadLine());

                        resultado = ((fahrenheit - 32) / 1.8);
                        Console.WriteLine("Grados celcius: " + resultado);
                        break;

                    case 6:
                        Console.WriteLine("Favor inserte grados fahrenheit");
                        fahrenheit = Convert.ToDouble(Console.ReadLine());

                        resultado = ((fahrenheit - 32) * 5 / 9 + 273.15);
                        Console.WriteLine("Grados kelvin: " + resultado);
                        break;




                }
                Console.WriteLine("Desea volver a intentarlo? ");
                si = Console.ReadLine();
                Console.Clear();
            }

            while (si == "si" || si == "SI");
        }
    }
}
