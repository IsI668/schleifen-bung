using System;
using System.Threading;
namespace Schleife_übung_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = 0;

            for (int i = 1; i <= 11; i++)
            {
                Thread.Sleep(500);
                Q = i * i;
                Console.WriteLine("Das Quadrat von {0}, ist {1} ", i, Q);
            }
        }
    }
}
