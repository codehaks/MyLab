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

            var t1=Task.Run(() => { Parallel.For(0, 10, (index) => ShowTime(index)); });
            var t2=Task.Run(() => { Parallel.ForEach("Hello World".ToCharArray(), (c) => ShowChar(c)); });

            Task.WaitAll(t1, t2);
                        
        }

        public static void ShowTime(int threadId)
        {
            //Thread.Sleep(new Random().Next(100,500));
            var now = DateTime.Now;
            Console.WriteLine($"{threadId} -> {now.Second}:{now.Millisecond} - {now.Ticks}");
        }


        public static void ShowChar(char c)
        {
            //Thread.Sleep(new Random().Next(100, 500));
            var now = DateTime.Now;

            Console.WriteLine($"{c} -> {now.Second}:{now.Millisecond} - {now.Ticks}");
        }



    }
}
