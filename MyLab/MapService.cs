using System;
using System.Collections.Generic;
using System.Text;

namespace MyLab
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class MapService
    {
        Point[] Points =  {
                new Point { X=1,Y=4},
                new Point { X=3,Y=6},
                new Point { X=5,Y=8}
            };

        public void Execute()
        {

            var p0 = Points[0];

            Move(p0);


            MoveOut(out Point p5);

            // --- Show results
            foreach (var p in Points)
            {
                Console.WriteLine($" P -> ({p.X},{p.Y})");
            }
        }

        public void Move(Point p)
        {
            p.X = p.X + 10;
            p.Y = p.X + 10;
            ////----
        }

        public void MoveRef(ref Point p)
        {
            p.X = p.X + 10;
            p.Y = p.X + 10;
        }

        public void MoveOut(out Point p)
        {
            p = new Point();
            p.X = 0;
            p.Y = 0;
        }

        public void MoveIn(in Point p)
        {
            //p.X = 5;

            Console.WriteLine($" P -> ({p.X},{p.Y})");
        }
    }
}
