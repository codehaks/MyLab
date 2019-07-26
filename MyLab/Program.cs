using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Threading.Tasks;

namespace MyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var filePath = @"D:\Projects\Data\books\Pride_and_prejudice.txt";

            var textAnalysis = new TextAnalysis();
            //var count=textAnalysis.FindWord("Jane", filePath);

            //var count = textAnalysis.FindWordParallel("Jane", filePath);

            //Console.WriteLine($" Count : {count}");

            //BenchmarkRunner.Run<TextAnalysis>();

            textAnalysis.FindWordParallel();

        }

    }

    public class TextAnalysis
    {
        [Benchmark]
        public int FindWord()
        {
            string word = "Jane";
            string filePath = @"D:\Projects\Data\books\Pride_and_prejudice.txt";

            var text = System.IO.File.ReadAllText(filePath);
            var wordList = text.Split(' ');

            int count = 0;

            for (int i = 0; i < wordList.Length; i++)
            {
                if (word==wordList[i])
                {
                    count++;
                }
            }

            return count;
        }

        [Benchmark]
        public int FindWordParallel()
        {
            string word = "Jane";
            string filePath= @"D:\Projects\Data\books\Pride_and_prejudice.txt";

            var text = System.IO.File.ReadAllText(filePath);
            var wordList = text.Split(' ');
            var parts = wordList.Length / 10;

            int count = 0;

            Parallel.For(0, 10, (index) => {
                Console.WriteLine(index);

                for (int i = index* parts; i < (index+1) * parts; i++)
                {
                    if (word == wordList[i])
                    {
                        count++;
                    }
                }

            });

           

            return count;
        }
    }
}
