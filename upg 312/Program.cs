using System;

namespace upg_312
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("hur många datorer har du");
           int numDat = int.Parse(Console.ReadLine());

            if (numDat == 1) 
            {
                Console.WriteLine("Du har 1 dator");
            }
            else
            {
                Console.WriteLine($"du har {numDat} atorer");
            }
        }
    }
}
