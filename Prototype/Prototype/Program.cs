using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(new Point(5, 5), 50.5);
            Rectangle r = new Rectangle(new Point(1, 2), new Point(3, 4), new Point(5, 6), new Point(7, 8));
            Point p = new Point(9, 10);
            ShapeHolder shapeHolder = new ShapeHolder();
            shapeHolder.add(c);
            shapeHolder.add(r);
            shapeHolder.add(p);

            Console.WriteLine(c);
            Console.WriteLine(r);
            Console.WriteLine(p);

            DoStuffWithCircle((Circle)c.clone(), (Rectangle)r.clone(), (Point)p.clone());

            Console.WriteLine(c);
            Console.WriteLine(r);
            Console.WriteLine(p);


        }

        public static void DoStuffWithCircle(Circle c, Rectangle r, Point p)
        {
            c.Center.X = -1;
            c.Center.Y = -1;
            c.Area = -1;

            r.corner1.X = -1;
            r.corner1.Y = -1;
            r.corner2.X = -1;
            r.corner2.Y = -1;
            r.corner3.X = -1;
            r.corner3.Y = -1;
            r.corner4.X = -1;
            r.corner4.Y = -1;

            p.X = -1;
            p.Y = -1;
        }
    }
}
