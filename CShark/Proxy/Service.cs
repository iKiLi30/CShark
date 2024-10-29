using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class Service : IService
    {
        public int Sum (int a, int b)
        {
            return a + b;
        }

        
    }
}