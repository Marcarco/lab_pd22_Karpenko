using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_12
{
    class Program
    {
        static bool Pam(int x)
        {
            if (x == 1)
                return false;
            int d = 2;
            while (x % d != 0)
                d++;
            if (d == x)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n;
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Ошибка ввода(n<=0)!");
            } while (n <= 0);
            Console.WriteLine("Введите элементы:");
            int x;
            List<int> A = new List<int>(n);
            for (int element = 1; element <= n; element++)
            {
                Console.Write($"A[{element}] = ");
                x = Convert.ToInt32(Console.ReadLine());
                A.Add(x);
            }
            int S = 0;
            bool t;
            foreach (int element in A)
            {
                t = Pam(element);
                if (t == true)
                {
                    S = S + element;
                }

            }
            Console.WriteLine($"Сумма простых: {S}");
            int p = 0;
            foreach (int element in A)
            {

                if (element % 2 == 0)
                {
                    p= p + element;
                }

            }
            p = Math.Abs(S - p);
            Console.WriteLine($"Разница: {p}");
            S = 0;
            foreach (int element in A)
            {

                S = S + element;
            }
            S = S / n;
            Console.WriteLine($"Среднее Арефмитическое: {S}");
            Console.ReadKey();
        }
    }
}
