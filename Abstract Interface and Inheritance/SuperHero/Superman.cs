using Inheritance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SuperHero
{
    public class Superman : Animal, IFlyable
    {

        public new string Fly()
        {
             
            return "Superman is Flying";
        }

        public override string Move()
        {
            return "Move by leg";
        }
    }
}
