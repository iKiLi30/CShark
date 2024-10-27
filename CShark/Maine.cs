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
            Logik logik= new Logik();

            Transport truck= new Truck();
            logik.Delivery(truck);

            Transport boath= new Boath();
            logik.Delivery(boath);
            
        }
    }
}