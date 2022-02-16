using System;

namespace _06_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int VARIABLE = 4000, YEAR = 1, Val = 24000, ACC = 4000;
            Console.WriteLine("                          END-OF-YEAR       ACCUMULATED");
            Console.WriteLine("YEAR     DEPRECIATION        VALUE        DEPRECIATION");
            Console.WriteLine("----     ------------     -----------     ------------");
            do
            {
                Console.WriteLine($"{YEAR,2} {VARIABLE,14} {Val,15} {ACC,16}");
                YEAR = YEAR + 1;
                Val = Val - VARIABLE;
                ACC = ACC + VARIABLE;
            } while (YEAR <= 7);
        }
    }
}
