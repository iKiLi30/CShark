using System;

namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова паттернщик!!");
            Logger.getInstance().Debug("Это СИНГЛТОН");
            Console.WriteLine("тестируем паттерн прототип!!!");
            Circle red = new Circle(10, "red");
            Circle blue =  new Circle(20,"blue");
            Circle red1 = (Circle)red.Clone();
            System.Console.WriteLine(red);
            System.Console.WriteLine(red1);
            System.Console.WriteLine(blue);
        }
    }
}