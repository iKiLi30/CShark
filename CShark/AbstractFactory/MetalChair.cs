using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class MetalChair : Chair
    {
        public override void sit()
        {
            System.Console.WriteLine("На метал стуле сидят");
        }     
        
    }
}