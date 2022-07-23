namespace Homework9
{
    class Task66
    {
//         Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
        public static void Main()
        {
            Console.WriteLine($"Введите число М");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            if (SumNumber(m, n, sum) < 0)
            {
                Console.WriteLine($"N должно быть больше M");
            }
            else
            {
            Console.WriteLine($"Сумма натуральных чисел:{SumNumber(m, n, sum)}");
                
            }
        }
        public static int SumNumber(int m, int n, int sum)
        {
            if (m == n && m != 0)
            {
                return sum + n;
            }
            else
                if (m < n)
            {
                sum = sum + m;
                return SumNumber(m+1,n, sum);
            }
            else
            {
                return n - m;
            }
        }
    }
}

