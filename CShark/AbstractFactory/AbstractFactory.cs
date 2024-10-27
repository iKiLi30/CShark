using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CShark
{
    abstract public class AbstractFactory
    {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();
    }
}