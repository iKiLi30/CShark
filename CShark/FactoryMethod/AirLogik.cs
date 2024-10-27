using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public class AirLogik : Logik
    {
        public override Transport CreateTransport()
        {
            return new AirPlane();
        }
    }

    public class AirPlane : Transport
    {
        public override void Go()
        {
            System.Console.WriteLine("Летим");
        }

        public override void Load()
        {
            System.Console.WriteLine("Щя взлечу");
        }

        public override void UnLoad()
        {
            System.Console.WriteLine("Мягкой посадки");
        }
    }
}