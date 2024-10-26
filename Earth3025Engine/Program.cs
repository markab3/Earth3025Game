using System;

namespace Earth3025Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing game.");
            UpdateClock clock = new UpdateClock();
            Console.WriteLine("Starting clock...");
            clock.Start();
            Console.WriteLine("Press Q to exit.");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q))
            {
                // do something
            }
            Console.WriteLine("Stopping clock...");
            clock.Stop();
            Console.WriteLine("Press enter to close.");
            Console.ReadLine();
        }
    }
}