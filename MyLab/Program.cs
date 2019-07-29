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

            var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };

            Parallel.ForEach("Hello World".ToCharArray(),options, (c,s) => ShowChar(c,s)); 
                        
        }    

        public static void ShowChar(char c,ParallelLoopState state)
        {
            Thread.Sleep(1000);
            
            var now = DateTime.Now;

            if (char.IsWhiteSpace(c))
            {
                //state.Stop();
                state.Break();
            }

            Console.WriteLine($"{c} -> {now.Second}:{now.Millisecond} - {now.Ticks}");
        }



    }
}
