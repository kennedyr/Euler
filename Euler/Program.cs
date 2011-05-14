using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine( Problem1.SumTheMultiplesOf3And5(1000) );

            sw.Stop();

            Console.WriteLine("Time used (float): {0} ms", sw.Elapsed.TotalMilliseconds);
            Console.WriteLine("Time used (rounded): {0} ms", sw.ElapsedMilliseconds);
            
        }
    }
}
