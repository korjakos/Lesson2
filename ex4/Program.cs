using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нурумов Олжас
            string log = "root";
            string password = "Geek";

            int count = 3;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();

                if (log == login && password == pass)
                {
                    Console.WriteLine("Успех!");
                    break;
                }
                --count;
                Console.WriteLine("Логин или пароль неверный. Осталось попыток " + count);
            } while (count > 0);
            Console.WriteLine("Вы заблокированы!");
        }
    }
}
