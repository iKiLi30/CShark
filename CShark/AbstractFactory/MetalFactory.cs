using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class MetalFactory : AbstractFactory
    {

        public override Chair CreateChaie()
        {
            return new MetalChair();
        }

        public override Table CtraetTable()
        {
            return new MetalTable();
        }
    }
    
}