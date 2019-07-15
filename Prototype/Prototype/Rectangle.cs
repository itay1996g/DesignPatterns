using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Rectangle : Shape
    {

        public Point corner1 { get; set; }
        public Point corner2 { get; set; }
        public Point corner3 { get; set; }
        public Point corner4 { get; set; }

        public Rectangle(Point one, Point two, Point three, Point four)
        {
            this.corner1 = one;
            this.corner2 = two;
            this.corner3 = three;
            this.corner4 = four;
        }

        public override string ToString()
        {
            return $"Rectangle overview: {this.corner1} {this.corner2} " +
                $"{this.corner3} {this.corner4}";
        }

        public override Shape clone()
        {
            return new Rectangle((Point)corner1.clone(), (Point)corner2.clone(), (Point)corner3.clone(), (Point)corner4.clone());
        }
    }
}