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
            Dinner(mfactory.CreateChair(), mfactory.CtraetTable());

            AbstractFactory wfactory = new WoodFactory();
            Dinner(wfactory.CreateChair(),wfactory.CtraetTable());


        }
        static void Dinner(Chair chair, Table table)
        {
            chair.sit();
            table.eat();
        }
    }
}