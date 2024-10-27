using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class DinnerService
    {
        Chair chair;
        Table table;

        public DinnerService(AbstractFactory factory)
        {
        chair = factory.CreateChair();
        table = factory.CreateTable();
        }

        public void Dinner()
        {
            chair.sit();
            table.eat();
        }
    }
}