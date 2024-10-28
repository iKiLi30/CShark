using System;


namespace CShark
{
    public class OwnRobotBuilder
    {
        List<object> _PartOfRobots = new List<object>();

        public void Add(object PartOfRobot)
        {
            this._PartOfRobots.Add(PartOfRobot);
        }

        public string ListPartOfRobot()
        {
            string str = string.Empty;

            for (int i = 0; i < this._PartOfRobots.Count;)
            {
                str += this._PartOfRobots[i] + ", ";
                str = str.Remove(str.Length - 2);
                return "Части в сборке: " + str +"\n";
            }

            return str;
        }
        
    }
}