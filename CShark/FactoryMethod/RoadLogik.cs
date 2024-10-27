using System;


namespace CShark
{
    public class RoadLogik : Logik
    {
        public override Transport CreateTransport()
        {
            return new Truck();
        }
    }
}