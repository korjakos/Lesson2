using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нурумов Олжас
            int a, b, c, min;
            Console.Write("Введите число А: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число Б: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число С: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)

            {
                min = a;
            }
            else if (b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine("Минимальное введенное число: " + min);
        }
    }
}
