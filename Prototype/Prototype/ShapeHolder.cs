using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class ShapeHolder :IProtoType<ShapeHolder>
    {
        IList<Shape> shapeList = new List<Shape>();

        public void add(Shape s)
        {
            shapeList.Add(s);
        }

        public override string ToString()
        {
            string toPrint = "";
            foreach (Shape shape in shapeList)
            {
                toPrint += shape + "\n";
            }
            return toPrint;
        }

        public ShapeHolder clone()
        {
            ShapeHolder shapeHolder = new ShapeHolder();
            foreach (Shape shape in shapeList)
            {
                shapeHolder.shapeList.Add(shape.clone());
            }
            return shapeHolder;
        }
    }
}
