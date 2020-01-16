using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдите размер массива  :");
            int n;
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Ошибка ввода(n<=0)!");
            } while (n <= 0);
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
                i++;
                if (i + 1 >= n && t != 1)
                {
                    i = 0;
                    t = 1;
                }
            }
            Console.WriteLine();
            t = 0;

            for (int i = 1; i < n; i++)
            {
                Console.Write(A[i] + " ");
                i++;
                if (i + 1 >= n && t != 1)
                {
                    i = -1;
                    t = 1;
                }
            }

            Console.ReadKey();

        }
    }
}
