using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyLab
{
    class Program
    {
        public static int[] numbers = Enumerable.Range(0, 1000_000).ToArray();


        public static int count = 0;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t1=Task.Factory.StartNew(IsOdd);
            var t2=Task.Factory.StartNew(IsEven);

            await Task.WhenAll(t1, t2);

            Console.WriteLine($" Count : {count}");


        }

        public static void IsOdd()
        {
            foreach (var number in numbers)
            {
                if (number % 2 !=0)
                {
                    count--;
                }
            }
        }

        public static void IsEven()
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
        }
    }

    
}
