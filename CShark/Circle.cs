using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    /// <summary>
    /// реализуем интерфейс iClonable 
    /// </summary>
    public class Circle : ICloneable
    {
        int radiuse;
        string color;

        public Circle(int radiuse, string color)
        {
            this.radiuse = radiuse;
            this.color = color;
        }

        public object Clone()
        {
            return new Circle(this.radiuse, this.color);
        }
        public override string ToString()
        {
            return color + " " + radiuse;
        }
    }
}