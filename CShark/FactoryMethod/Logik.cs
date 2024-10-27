using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    abstract public class Logik
    {
        public abstract Transport CreateTransport();

        public void Delivery()
        {
            Transport transport= CreateTransport();
            transport.Load();
            transport.Go();
            transport.UnLoad();
        }
    }
}