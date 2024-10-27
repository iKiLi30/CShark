using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова паттернщик!!");
            Logger.getInstance().Debug("Это СИНГЛТОН");

            System.Console.WriteLine("Абстрактная фабрика пошла, пошла, пошла");                        
            
            AbstractFactory mfactory = new MetalFactory();
            AbstractFactory wfactory = new WoodFactory();

            DinnerService mdinner = new DinnerService(mfactory);
            DinnerService wdinner = new DinnerService(wfactory);
            mdinner.Dinner();
            wdinner.Dinner();



        }
        
    }
}