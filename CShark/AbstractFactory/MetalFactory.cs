using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class MetalFactory : AbstractFactory
    {

        public override Chair CreateChair()
        {
            return new MetalChair();
        }

        public override Table CreateTable()
        {
            return new MetalTable();
        }
    }
    
}