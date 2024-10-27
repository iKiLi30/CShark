using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class SeaLogik : Logik
    {
        public override Transport CreateTransport()
        {
            return new Boath();
        }
    }
}