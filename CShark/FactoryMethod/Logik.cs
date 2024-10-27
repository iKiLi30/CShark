using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class Logik
    {   
        public void Delivery(Transport transport)
        {
        transport.Load();
        transport.Go();
        transport.UnLoad();
        }
    }
}