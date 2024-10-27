using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class WoodTable : Table
    {
        
        public override void eat()
        {
            System.Console.WriteLine("Едим за деревянным столом");
        }
    }
}