namespace Homework9
{
    class Task64
    {
        // // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
        //  в промежутке от M до N.
        // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
        // M = 4; N = 8. -> ""4, 6, 7, 8""
        public static void Main()
        {
            Console.WriteLine($"ВВедите число М");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"ВВедите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (PrintNumber(m, n ) < 0)
            {
                Console.WriteLine($"N должно быть больше M");
            }
            else
            {
                Console.WriteLine($"Ряд натуральных чисел:");
                PrintNumber(m, n);
            }
        }
        public static int PrintNumber(int m, int n)
        {
            if (m == n && m != 0)
            {
                Console.WriteLine("" + m);
                return m;
            }
            else
                if (m < n)
            {
                Console.WriteLine("" + m);
                return PrintNumber(m + 1, n);
            }
            else
            {
                return n - m;
            }
        }
    }
}

