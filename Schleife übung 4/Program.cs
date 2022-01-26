using System;
using System.Threading;
namespace Schleife_übung_4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 100; i >= 10; i=i-10) //i--  -> i-=1  -> i=i-1
            {
                Thread.Sleep(0);
                Console.WriteLine(i);
            }

        }
    }
}
