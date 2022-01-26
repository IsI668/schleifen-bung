using System;
using System.Threading;
namespace SchleifenUebungA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  Q = 0;

            for (int i = 50; i >= 0; i--)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }





        }
    }
}
