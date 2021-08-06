using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нурумов Олжас
            int sum = 0;
            while(true)
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) break;

                else
                    if (a % 2 == 1) sum = a + sum;
            }
            Console.WriteLine("Сумма нечетных чисел равна: " + sum);
        }
    }
}
