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

            int v;
            Console.WriteLine("Escribe el numero de la operacion que deseas realizar: ");
            Console.WriteLine("1- Suma: ");
            Console.WriteLine("2-Resta: ");
            Console.WriteLine("3-Multiplicacionr: ");
            Console.WriteLine("4-Division: ");
            Console.WriteLine("5-Salir: ");
            v = int.Parse(Console.ReadLine());

            //Console.WriteLine(v);
            //Console.ReadLine();

            switch (v)
            {
                case 1:
                    Console.WriteLine("Has elegido Sumar");
                    Console.WriteLine("Introduce el primer numero");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo numero");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado es: ");
                    Console.WriteLine(calc1.Suma(num1, num2));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Has elegido Restar");
                    Console.WriteLine("Introduce el primer numero");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo numero");
                    int num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado es: ");
                    Console.WriteLine(calc1.Resta(num3, num4));
                    Console.ReadLine();
                    break;
               case 3:
                    Console.WriteLine("Has elegido Multiplicar");
                    Console.WriteLine("Introduce el primer numero");
                    int num5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo numero");
                    int num6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado es: ");
                    Console.WriteLine(calc1.Multiplicacion(num5, num6));
                    Console.ReadLine();
                case 4:
                    Console.WriteLine("Has elegido Dividir");
                    Console.WriteLine("Introduce el primer numero");
                    int num7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo numero");
                    int num8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado es: ");
                    Console.WriteLine(calc1.Multiplicacion(num7, num8));
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Has elegido Salir");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


            
        }

        public int Division(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Multiplicacion(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Resta(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Suma(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
