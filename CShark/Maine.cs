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
            Circle red1 = (Circle)red.Clone();
            System.Console.WriteLine(red);
            System.Console.WriteLine(red1);

            CircleXY blue =  new CircleXY(12,12,20,"blue");
            CircleXY blue1 = (CircleXY)blue.Clone();
            System.Console.WriteLine(blue);
            System.Console.WriteLine(blue1);
        }
    }
}