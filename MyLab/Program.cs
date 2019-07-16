using System;

namespace MyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public abstract class Shape {
            public int Color { get; set; }
            public abstract float Area();
            //public virtual float Area() {

            //    return 0;
            //}
        }

        public class Circle : Shape
        {
            public int Radius { get; set; }
            public override float Area()
            {
                return Radius* Radius*3.14f;
            }
        }

        public class Ellipse : Circle
        {
            public override float Area()
            {
                return base.Area();
            }
        }

        public class Line : Shape
        {
            public override float Area()
            {
                // line has no area
                throw new InvalidOperationException();
            }
        }

        public interface IArea
        {

        }


    }
}
