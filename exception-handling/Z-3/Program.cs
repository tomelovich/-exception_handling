using System;
namespace Z_3
{
    class Program
    {
        private static int InvertDigits(int k)
        {
            int result = 0;
            while (k != 0)
            {
                result = result * 10 + k % 10;
                k = k / 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число:");

                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(InvertDigits(k));
            }
            
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
