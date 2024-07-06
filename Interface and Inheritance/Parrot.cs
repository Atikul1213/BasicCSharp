using Inheritance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Parrot : Animal,  IFlyable
    {
        public new string Fly()
        {
            return "Parrot is flying";
        }

        public override string Move()
        {
            return "Move by wings in air";
        }
    }
}
