using System;

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}*{n}={i * n}");
            }
            int j = 0;
            while (n != 0)
            {
                j++;
                n /= 10;

            }
            Console.WriteLine($"Количество разрядов введенного числа : {j}");
                Console.ReadKey();
            

        }
    }
}
