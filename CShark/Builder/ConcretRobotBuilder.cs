using System;


namespace CShark
{
    public class ConcretRobotBuilder : RobotBuilder
    {     
        OwnRobotBuilder _orb = new OwnRobotBuilder();
        public override void BodyBuilder() => System.Console.WriteLine("Тело");

        public override void HandBuilder() => System.Console.WriteLine("Руки");

        public override void HeadBuilder() => System.Console.WriteLine("Голова");

        public override void LegBuilder() => System.Console.WriteLine("Ноги");

        public override void OilBuilder() => System.Console.WriteLine("Масло");

        public override void SoftwareBuilder() => System.Console.WriteLine("Прошивка");

        public OwnRobotBuilder GetRobot()
        {
            OwnRobotBuilder result  = this._orb;
            return result;
        }
    }

}