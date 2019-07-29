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

            //ParallelOptions options
            //= new ParallelOptions() { MaxDegreeOfParallelism = 4 };
            //Parallel.For(0, 10,options, (index) => ShowTime(index));


            Parallel.For(0, 10, (index) => ShowTime(index));
            Parallel.ForEach("Hello World".ToCharArray(), (c) => ShowChar(c));

        }

        public static void ShowTime(int threadId)
        {
            //Thread.Sleep(new Random().Next(100,500));
            //Thread.Sleep(1000);
            Console.WriteLine($"{threadId} -> {DateTime.Now.Second}:{DateTime.Now.Millisecond}");
        }


        public static void ShowChar(char c)
        {
            Thread.Sleep(new Random().Next(100, 500));
            Console.WriteLine($"{c} -> {DateTime.Now.Second}:{DateTime.Now.Millisecond}");
        }



    }
}
