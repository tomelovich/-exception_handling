using System;

namespace Z_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y1 = 1 - (4 / (4 * x + 8));
                Console.WriteLine(Math.Round(y1, 3));
                double y2 = Math.Pow(Math.Tan(x), 2) + 1 / x - 1;
                Console.WriteLine(Math.Round(y2, 3));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите цифру!");
            }
        }
    }
}
