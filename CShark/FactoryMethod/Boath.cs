using System;

namespace CShark
{
    public class Boath : Transport
    {
        public override void Load()
        {
            System.Console.WriteLine("Загрузить лодку");
        }

        public override void Go()
        {
            System.Console.WriteLine("Поплыли");
        }

        public override void UnLoad()
        {
            System.Console.WriteLine("Выгружай лодку");
        }
    }
}