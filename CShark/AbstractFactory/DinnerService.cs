using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class DinnerService
    {
        public DinnerService(AbstractFactory factory)
        {
            Chair chair = factory.CreateChair();
            Table table = factory.CtraetTable();
        }
    }
}