using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc1 = new Calculadora();

            int v, num1=0, num2=0, resultado = 0;
            Console.WriteLine("Escribe el numero de la operacion que deseas realizar: ");
            Console.WriteLine("1- Suma: ");
            Console.WriteLine("2-Resta: ");
            Console.WriteLine("3-Multiplicacionr: ");
            Console.WriteLine("4-Division: ");
            Console.WriteLine("5-Salir: ");
            v = int.Parse(Console.ReadLine());

            switch (v)
            {
                case 1:
                    Console.WriteLine("Has elegido Sumar");
                    PedirNumeros(ref num1, ref num2);

                    resultado = calc1.Suma(num1, num2);                    
                    break;
                case 2:
                    Console.WriteLine("Has elegido Restar");
                    PedirNumeros(ref num1, ref num2);

                    resultado = calc1.Resta(num1, num2);
                    break;
               case 3:
                    Console.WriteLine("Has elegido Multiplicar");
                    PedirNumeros(ref num1, ref num2);

                    resultado = calc1.Multiplicacion(num1, num2);
                    break;
                case 4:
                    Console.WriteLine("Has elegido Dividir");
                    PedirNumeros(ref num1, ref num2);

                    resultado = calc1.Division(num1, num2);
                    break;
                case 5:
                    Console.WriteLine("Has elegido Salir");
                    return;
                default:
                    Console.WriteLine("Error");
                    return;
            }

            Console.WriteLine(@"El resultado es: {0}", resultado.ToString());
            Console.ReadLine();
        }

        public static void PedirNumeros(ref int num1, ref int num2)
        {
            Console.WriteLine("Introduce el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());
        }
    }
}
