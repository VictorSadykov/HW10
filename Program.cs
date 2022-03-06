using System;

namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            Summator summator = new Summator(logger);
            int a = 0;
            int b = 0;
            bool bl;
            do
            {
                try
                {
                    Console.Write("Введите число 1: ");
                    a = int.Parse(Console.ReadLine());
                    bl = false;
                }
                catch (Exception)
                {
                    summator.Logger.Error("Неверный ввод данных");
                    bl = true;
                }
            } while (bl);

            summator.Logger.Event($"Пользователь успешно ввёл первое число ({a})");

            do
            {
                try
                {
                    Console.Write("Введите число 2: ");
                    b = int.Parse(Console.ReadLine());
                    bl = false;
                }
                catch (Exception)
                {
                    summator.Logger.Error("Неверный ввод данных");
                    bl = true;
                }
            } while (bl);

            summator.Logger.Event($"Пользователь успешно ввёл второе число ({b})");
            Console.WriteLine("Сумма: " + summator.Sum(a,b));
            summator.Logger.Event($"Программа успешно заверишила своё действие.");

        }
    }
}
