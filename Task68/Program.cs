namespace Homework9
{
    class Task68
    {
        // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        // m = 2, n = 3 -> A(m,n) = 29
        public static void Main()
        {
            Console.WriteLine($"Введите число М");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m < 0 & n < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                AkkermanFunk(m, n);
                Console.WriteLine($"Функция Аккермана: {AkkermanFunk(m, n)}");
            }
        }

        public static int AkkermanFunk(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else
                if (n == 0)
            {
                return AkkermanFunk(m - 1, 1);
            }
            else
            {
                return AkkermanFunk(m - 1, AkkermanFunk(m, n - 1));
            }
        }
    }
}

