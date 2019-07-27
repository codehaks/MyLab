using System;

namespace MyLab
{
    class Program
    {
        public delegate int Calculation(int x, int y);

        static void Main(string[] args)
        {
            Calculation calc = Plus;

            var result1 = calc(2, 3);

            calc = Multiply;
            var result2 = calc(2, 3);

            calc = (int x, int y) => { return (x - y); };
            var result3 = calc(7, 8);

            Console.WriteLine($" Result1 : {result1} \n result2 : {result2} \n result3 : {result3}");
        }

        static public int Plus(int x, int y)
        {
            return x + y;
        }

        static public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
