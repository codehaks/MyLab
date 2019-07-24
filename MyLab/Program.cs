using System;

namespace MyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var filePath = @"D:\Projects\Data\books\Pride_and_prejudice.txt";

            var textAnalysis = new TextAnalysis();
            var count=textAnalysis.FindWord("Jane", filePath);

            Console.WriteLine($" Count : {count}");
            
        }

    }

    class TextAnalysis
    {
        public int FindWord(string word,string filePath)
        {
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

        public int FindWordParallel(string word, string filePath)
        {
            var text = System.IO.File.ReadAllText(filePath);
            var wordList = text.Split(' ');

            int count = 0;

            for (int i = 0; i < wordList.Length; i++)
            {
                if (word == wordList[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
