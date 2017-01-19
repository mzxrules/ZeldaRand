//mzxrules 2017
using System;

namespace ZeldaRand
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = TruthSpinner.Solve();

            Console.WriteLine("Results: ");
            Console.WriteLine($"{result[0]}, {result[1]}, {result[2]})");
            Console.ReadLine();
        }
        void RandClassTest()
        {
            Rand r = new Rand();

            Console.WriteLine($"{r.Next():X8}, {r.Next():X8}, {r.Next():X8}");
            r.SetSeed(0);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r.NextFloat());
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
