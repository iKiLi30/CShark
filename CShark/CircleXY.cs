using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class CircleXY : Circle
    {
        int x ,y;
        public CircleXY(int x,int y, int radiuse, string color) : base(radiuse,color) 
        { 
            this.x = x;
            this.y = y;
        }
        public override object Clone()
        {
            Circle circle= (Circle)base.Clone();
            return new CircleXY(x,y,circle.radiuse,circle.color);
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.x + " " + this.y;
        }
    }
}