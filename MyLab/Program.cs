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

            Task.Factory.StartNew(() => Print('.'));
            Task.Factory.StartNew(() => Print('?'));

            Print('-');

            Console.WriteLine("Done!");
        }

        public static void Print(char c)
        {

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }

        }




    }
}
