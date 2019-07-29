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
            
            Parallel.For(0, 10, (index) => SetValue(index));

            Console.WriteLine($"Finale value (x) = {X}");
        }

        public static int X { get; set; }

        public static void SetValue(int threadId)
        {
            //Thread.Sleep(new Random().Next(100,500));
            //Thread.Sleep(1000);

            X = threadId;
            Console.WriteLine($"{X} -> {DateTime.Now.Second}:{DateTime.Now.Millisecond}");
        }


       
    }
}
