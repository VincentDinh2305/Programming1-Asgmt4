using System;

namespace _06_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = number * 2;
            do
            {
                Console.WriteLine($"{number} {sum}");
                sum += number;
            } while (sum <= 100);
        }
    }
}
