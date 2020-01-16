using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{


    class Program
    {
        static int KilkistTsifr(int x)
        {
            int k = 1;
            while (x > 10)
            {
                x = x / 10;
                k++;
            }

            return (k);
        }

        static int NewChuslo(int k, int x)
        {
            int n = 0;
            k--;
            while (k >= 0)
            {
                n = (x % 10) * Convert.ToInt32(Math.Pow(10, k)) + n;
                k--;
                x = x / 10;
            }

            return n;
        }

        static void zad1(int x)
        {
            int n = x % 10;
            Console.Write(n);
            x = x / 10;
            if (x != 0)
                zad1(x);

        }

        static int KilkistSumvoliv(string x)
        {
            int k = 0;
            foreach (int i in x)
            {
                k++;
            }
            return (k);
        }

        static char[] NewString(int k, char[] x)
        {
            char[] n = new char[k];
            int j = 0;
            k--;
            for (int i = k; i >= 0; i--)
            {
                n[j] = x[i];
                j++;
            }
            return n;
        }

        static char[] zad2(string x, int k)
        {
            if (k == 0)
            {
                foreach (int i in x)
                {
                    k++;
                }

                zad2(x, k);
            }
            char[] n = new char[k];
            int j = 0;
            k--;
            for (int i = k; i >= 0; i--)
            {
                n[j] = x[i];
                j++;
            }
            return n;

        }



        static int ChusloPisla(double x)
        {
            int a = (int)x;
            do
            {
                x = x * 10;
                a = a * 10;
            } while (x % 10 != 0);

            x = x / 10;
            a = a / 10;
            x = x - a;
            a = (int)x;
            return (a);
        }

        static double zad3(double x, int A, int B, int a, int b) // A - число перед , / В - після ; a - кількість цифр перед , / b - після
        {
            double newDoub = 0;
            if (B == 0)
            {
                double X = x;
                A = (int)x;
                B = A;
                do
                {
                    x = x * 10;
                    B = B * 10;
                } while (x % 10 != 0);
                B = B / 10;
                x = x / 10;
                x = x - B;
                B = (int)x;
                zad3(X, B, A, a, b);
            }
            else if (b == 0)
            {
                int k = 1;
                int q = B;
                while (q > 10)
                {
                    q = q / 10;
                    k++;
                }

                int test = -1;

                if (a == 0)
                {
                    if (k == 0)
                        k = test;
                    zad3(x, B, A, k, b);
                }
                else
                {
                    if (a == -1)
                        a = 0;
                    zad3(x, A, B, a, k);
                }

            }
            else
            {
                double nB = 0;
                double i = b;
                i--;
                while (i >= 0)
                {
                    nB = (B % 10) * (Math.Pow(10, i)) + nB;
                    i--;
                    B = B / 10;
                }

                newDoub = nB / Math.Pow(10, b);


                double nA = 0;
                a--;
                while (a >= 0)
                {
                    nA = (A % 10) * (Math.Pow(10, a)) + nA;
                    a--;
                    A = A / 10;
                }

                newDoub = newDoub + nA;
            }

            return (newDoub);

        }

        static char[] string1(string x)
        {

            int k = 0;
            int i = 0;
            while (x[i] != ',')
            {
                i++;
                k++;
            }
            char[] n = new char[k];
            int j = 0;
            k--;
            i = 0;
            for (i = k; i >= 0; i--)
            {
                n[j] = x[i];
                j++;
            }
            return n;
        }
        static char[] string2(string x)
        {
            int k = 0;
            int i = 0;
            while (x[i] != ',')
            {
                i++;
                k++;
            }

            int b = k;
            i++;
            k = 0;
            foreach (var i in x)
            {
                i++;
                k++;
                b++;
            }


            char[] n = new char[k];
            int j = 0;
            k--;
            int a = 0;
            for (a = b; a >= k; a--)
            {
                n[j] = x[a];
                j++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Виберiть дiю:");
            Console.WriteLine("Методи:");
            Console.WriteLine("1 - Виводить на екран введене число з клавiатури в зворотному порядку (1234 -> 4321)");
            Console.WriteLine("2 - Виводить будь-яку строку в зворотному порядку (АБВ -> ВБА)");
            Console.WriteLine("3 - Дробовi числа виводяться в зворотному порядку i цiла частина i дробова (123,456 -> 321,654)");
            Console.WriteLine("4 - Виводити будь-яку строку в зворотному порядку i всi елементи пiсля “магiчного знаку” теж в зворотному(АБВ,ГДЕ -> ВБА,ЕДГ)");
            Console.WriteLine("Рекурсiя:");
            Console.WriteLine("11 - Виводить на екран введене число з клавiатури в зворотному порядку (1234 -> 4321)");
            Console.WriteLine("22 - Виводить будь-яку строку в зворотному порядку (АБВ -> ВБА)");
            Console.WriteLine("33 - Дробовi числа виводяться в зворотному порядку i цiла частина i дробова (123,456 -> 321,654)");
            Console.WriteLine("44 - Виводити будь-яку строку в зворотному порядку i всi елементи пiсля “магiчного знаку” теж в зворотному(АБВ,ГДЕ -> ВБА,ЕДГ)");
            Console.WriteLine("7 - Реалiзувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)");
            Console.WriteLine("8 - Виконати пункт 7 з використанням ключових слiв ref i out");
            Console.WriteLine("0 - Кiнець");
            string d;

            int test = 0;
            int x, a, A, b, B;
            string s, s1, s2;
            string ns;
            char[] arr;
            double D;


            do
            {
                Console.Write("Дiя - ");
                d = Console.ReadLine();
                switch (d)
                {
                    case "1":
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{x} -> {NewChuslo(KilkistTsifr(x), x)}");
                        break;

                    case "2":
                        s = Console.ReadLine();
                        arr = new char[KilkistSumvoliv(s)];
                        arr = s.ToCharArray();
                        ns = new string(NewString(KilkistSumvoliv(s), arr));
                        Console.WriteLine($"{s} -> {ns}");
                        break;
                    case "3":
                        D = Convert.ToDouble(Console.ReadLine());
                        B = ChusloPisla(D);
                        b = KilkistTsifr(B);
                        A = (int)D;
                        a = KilkistTsifr(A);
                        if (a != 0)
                            Console.WriteLine($"{A} -> {NewChuslo(a, A)}.{NewChuslo(b, B)}");
                        else
                        {
                            Console.WriteLine($"{A} -> 0.{NewChuslo(b, B)}");
                        }
                        break;

                    case "4":
                        s = Console.ReadLine();
                        arr = new char[KilkistSumvoliv(s)];
                        arr = s.ToCharArray();
                        ns = new string(NewString(KilkistSumvoliv(s), arr));
                        Console.WriteLine($"{s} -> {ns}");
                        break;
                    case "11":
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"{x} -> ");
                        zad1(x);
                        Console.WriteLine();
                        break;

                    case "22":
                        s = Console.ReadLine();
                        ns = new string(zad2(s, 0));
                        Console.WriteLine($"{s} -> {ns}");

                        break;
                    case "33":
                        D = Convert.ToDouble(Console.ReadLine());
                        double qqq = zad3(D, 0, 0, 0, 0);
                        Console.WriteLine($"{D} -> {zad3(D, 0, 0, 0, 0)}");
                        break;

                    case "44":
                        s = Console.ReadLine();
                        s1 = new string(string1(s));
                        s2 = new string(string2(s));
                        Console.WriteLine($"{s} -> {s1},{s2}");
                        break;
                    case "7":

                        break;

                    case "8":

                        break;

                    case "0":
                        Console.WriteLine("The End!");
                        test = 1;
                        break;
                    default:
                        Console.WriteLine("Ви натиснули не вiрну букву!");
                        break;

                }

            } while (test != 1);

            Console.ReadKey();
        }
    }
}
