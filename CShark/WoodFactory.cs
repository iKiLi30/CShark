using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class WoodFactory : AbstractFactory
    {
        public override Chair CreateChair()
        {
            return new WoodChair();
        }

        public override Table CtraetTable()
        {
            return new WoodTable();
        }
    }
}