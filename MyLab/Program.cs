using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLab
{
    class Program
    {
        public static int[] numbers = Enumerable.Range(0, 1000_000).ToArray();

        public static int count = 0;

        public static List<int> numList = new List<int>();
        //public static ConcurrentBag<int> numList = new ConcurrentBag<int>();


        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t1=Task.Factory.StartNew(IsOdd);
            var t2=Task.Factory.StartNew(IsEven);

            await Task.WhenAll(t1, t2);

            Console.WriteLine($" Count : {numList.Count}");


        }

        public static void IsOdd()
        {
            foreach (var number in numbers)
            {
                if (number % 2 !=0)
                {
                    //count--;
                    numList.Add(number);
                }
            }
        }

        public static void IsEven()
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    //count++;
                    numList.Add(number);
                }
            }
        }
    }

    
}
