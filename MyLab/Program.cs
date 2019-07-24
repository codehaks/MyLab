using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task.Factory.StartNew(() => Print('1'));
            Task.Factory.StartNew(() => Print('2'));

            Print('3');

            Console.WriteLine("Done!");
        }

        private static readonly object _printLock = new object();

        public static void Print(char c)
        {
            lock (_printLock)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(c);
                    Thread.Sleep(100);
                }

            }

        }





    }
}
