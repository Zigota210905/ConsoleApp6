using static System.Console;
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Зад 1");
            WriteLine("Ввелите трехзначное число");
            int b = int.Parse(ReadLine());
            NetDeciat(ref b);
            WriteLine("Пустые лдесятки");
            WriteLine(b);
            WriteLine("Зад 2");
            WriteLine("Введите кординату x");
            int x1 = int.Parse(ReadLine());
            WriteLine("Введите кординату y");
            int y1 = int.Parse(ReadLine());
            shax(x1, y1);
            WriteLine("Зад 3");
        }
        /// <summary>
        /// обнуляет десятки
        /// </summary>
        /// <param name="a"></param>
        /// <exception cref="ArgumentException"></exception>
        static void NetDeciat(ref int a)
        {
            if ((a < 100) || (a > 999))
                throw new ArgumentException("a должна быть  <100 or >999");
            a = (a % 10) + (a / 100) * 100;
        }
        static void shax(int x, int y)
            ///Шахматы
        {
            if ((x < 1) || (x > 8) || (y < 1) || (y > 8))
                throw new ArgumentException("x and y должны быть <1 or >8");
            if ((x + y) % 2 == 1)
                WriteLine("Белое");
            if ((x + y) % 2 == 0)
                WriteLine("черное");
        }
    }
}
