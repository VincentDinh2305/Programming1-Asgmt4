using System;

namespace _06_09
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt32 number = 1000002;
            UInt64 sum = 0;
            while (number < 2000000)
            {
                sum += number;
                number += 3;
            }
            Console.WriteLine("sum is {0}", sum);
        }
    }
}
