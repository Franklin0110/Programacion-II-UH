using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            float sumatoria = 0, num1 = 0, num2 = 0;    
            do
            {
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Dividir");
                Console.WriteLine("5- Salir");
                op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: 
                        Console.WriteLine("Dijite el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dijite el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        sumatoria = num1 + num2;    
                        Console.WriteLine("La suma de sus dos numeros es " + sumatoria);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Dijite el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dijite el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        sumatoria = num1 - num2;
                        Console.WriteLine("La resta de sus dos numeros es " + sumatoria);

                        Console.ReadKey();
                        break;
                case 3:
                        Console.WriteLine("Dijite el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dijite el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        sumatoria = num1 * num2;
                        Console.WriteLine("La Multiplicacion de sus dos numeros es " + sumatoria);
                        Console.ReadKey();
                        break;
                case 4:
                        Console.WriteLine("Dijite el numero 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dijite el numero 2");
                        num2 = int.Parse(Console.ReadLine());
                        sumatoria = num1 / num2;
                        Console.WriteLine("La division de sus dos numeros es " + sumatoria);
                        Console.ReadKey();
                        break;
                case 5: 
                        break;

                    default:
                         Console.WriteLine("Dato introducido invalido");
                        break;
                    
            }
            } while (op!=5);

        }
    }
}
