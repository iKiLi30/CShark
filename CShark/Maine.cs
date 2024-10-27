using System;


namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова паттернщик!!");
            Logger.getInstance().Debug("Это СИНГЛТОН\n");

            System.Console.WriteLine("Это фабрика");
            
            Logik Rlogik = new RoadLogik();
            Rlogik.Delivery();

            Logik Slogik = new SeaLogik();
            Slogik.Delivery();

            Logik Alogik = new AirLogik();
            Alogik.Delivery();
            
        }
    }
}