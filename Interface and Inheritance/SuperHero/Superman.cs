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

        public string Fly()
        {
            return "Superman is Flying";
        }

    }
}
