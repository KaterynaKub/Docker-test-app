using System;
using System.Threading;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arg = args.Length > 0 ? Convert.ToInt32(args[0]) : -1;
            var counter = 0;
            while(arg == -1 || counter < arg)
            {
                Console.WriteLine($"Hello from docker! Counter {++counter}");
                Thread.Sleep(1000);
            }
        }
    }
}
