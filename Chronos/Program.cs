using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch chrono1 = new Stopwatch();
            Stopwatch chrono2 = new Stopwatch();

            chrono1.Start();
            Thread.Sleep(500);
            chrono2.Start();
            Thread.Sleep(250);

            chrono1.Stop();
            chrono2.Stop();

            Console.WriteLine($"Chrono1: {chrono1.ElapsedMilliseconds/1000:f4}");
            Console.WriteLine($"Chrono2: {chrono2.ElapsedMilliseconds/1000:f4}");
        }
    }
}
