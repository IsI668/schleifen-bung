using System;
using System.Threading;
namespace schleifen_übung
{
    class Program
    {
        static void Main(string[] args)
        {
           int a= 50;

            for (int i =50;  i>= 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

        }
    }
}
