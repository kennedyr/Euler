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

            Stopwatch sw = new Stopwatch();

            sw.Start();
            Console.WriteLine( Problem1.SumTheMultiplesOf3And5(1000) );
            sw.Stop();
            Console.WriteLine("Time used (float): {0} ms", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            Console.WriteLine(Problem1.SumTheMultiplesOf3And5_Optimized(1000));
            sw.Stop();
            Console.WriteLine("Time used (float): {0} ms", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            Console.WriteLine(Problem1.SumTheMultiplesOf3And5_Mathematically(1000));
            sw.Stop();
            Console.WriteLine("Time used (float): {0} ms", sw.Elapsed.TotalMilliseconds);

        }
    }
}
