using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumatoria = 0;
            int[,] matrix = new int[3, 3];

            int[,] matrix2 = new[,] { { 1, 2, 3 }, { 5, 4, 6 } };
            Console.WriteLine("*********************** MATRIX 1 *********************");
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matrix[i, c] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************** MATRIX 2 *********************");
            for (int i = 0; i < 2; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matrix2[i, c] + "");

                    sumatoria += matrix2[i, c];
                }

                Console.WriteLine();
            }
            Console.WriteLine("Sumatoria = {0}", sumatoria);
            Console.ReadKey();
        }
    }
}
