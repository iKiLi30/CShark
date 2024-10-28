using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    /// <summary>
    /// абстрактный клас в котором робот собирается
    /// </summary>
    abstract public class RobotBuilder
    {
        abstract public void BodyBuilder();
        abstract public void HeadBuilder();
        abstract public void OilBuilder();
        abstract public void LegBuilder();
        abstract public void HandBuilder();
        abstract public void SoftwareBuilder();        
    }
}