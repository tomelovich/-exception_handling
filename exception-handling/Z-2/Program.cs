using System;

namespace Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double f;
                Console.WriteLine("Введите x:");
                double x = Convert.ToDouble(Console.ReadLine());
                if ((x > 0) && (x < 1))
                {
                    f = x - 4;
                }
                else if (x>=1)
                {
                    f = x / (2 * x - 2);
                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine(f);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка!");
            }
            catch (Exception)
            {
                Console.WriteLine("Вы вышли за диапазон");
                throw;
            }
        }
    }
}
