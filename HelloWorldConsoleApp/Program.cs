using System;
using System.Threading;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(var i =0; i < 30; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Hello World ENDED");
        }
    }
}
