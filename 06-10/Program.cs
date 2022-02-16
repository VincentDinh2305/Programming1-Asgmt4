using System;

namespace _06_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int celcius = 100, end = 0, decrement = 10;
            Console.WriteLine("Celcius      Fahreheit");
            while (celcius >= 0)
            {
                double fahreheit = celcius * 9 / 5 + 32;
                Console.WriteLine($"{celcius,7} {fahreheit,14}");
                celcius -= decrement;
            };
        }
    }
}
