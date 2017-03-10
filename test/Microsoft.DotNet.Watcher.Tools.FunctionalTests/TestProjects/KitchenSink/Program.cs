using System;
using System.Diagnostics;

namespace KitchenSink
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            Console.WriteLine("PID = " + Process.GetCurrentProcess().Id);
            Console.WriteLine("DOTNET_WATCH = " + Environment.GetEnvironmentVariable("DOTNET_WATCH"));
        }
    }
}
