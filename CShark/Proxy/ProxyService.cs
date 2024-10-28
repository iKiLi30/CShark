using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class ProxyService : IService
    {
        IService service;
        public ProxyService(IService service)
        {
            this.service = service;
        }
        public int Sum(int a, int b)
        {
            return service.Sum(a, b);
        }
    }
}