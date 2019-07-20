using System;

namespace MyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //var map = new MapService();
            //map.Execute();

            if (args.Length>0)
            {
                int.TryParse(args[0], out var number);
                Console.WriteLine(number);
            }
            
            
        }
    }
}
