using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class WoodChair : Chair
    {
        public override void sit()
        {
            System.Console.WriteLine("На деревянном стуле сидят");
        }
       
    }
}