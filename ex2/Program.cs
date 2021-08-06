using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нурумов Олжас
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            while (a > 0)
            {
                x++;
                a /= 10;
            }
            Console.WriteLine("Количество чисел : " + x);
        }
    }
}
