using System;

namespace _06_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double average;
            int sum = number * 2;
            do
            {
                Console.WriteLine($"{number} {sum}");
                sum += number;
            } while (sum <= 100);
            average = sum / number;
            Console.WriteLine($"The average of those numbers are {average}");
        }
    }
}
