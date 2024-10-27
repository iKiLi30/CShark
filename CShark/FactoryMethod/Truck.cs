using System;

namespace CShark
{
    public class Truck : Transport
    {
        public override void Load()
        {
            System.Console.WriteLine("Загрузить");
        }

        public override void Go()
        {
            System.Console.WriteLine("Поехали");
        }

        public override void UnLoad()
        {
            System.Console.WriteLine("Выгружай");
        }
    }
}