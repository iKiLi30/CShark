using System;

namespace CShark
{
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здарова паттернщик!!");
            Logger.getInstance().Debug("Это СИНГЛТОН");

            var Crb = new ConcretRobotBuilder();
            Crb.SoftwareBuilder();
            Crb.HeadBuilder();
            Crb.LegBuilder();
            Crb.OilBuilder();
            Crb.HandBuilder();
            Crb.BodyBuilder();
            System.Console.WriteLine(Crb.GetRobot().ListPartOfRobot());
                        
        }
    }
}