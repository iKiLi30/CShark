using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    public abstract class Transport
    {
        abstract public void Load();
        abstract public void Go();
        abstract public void UnLoad();
    }
}