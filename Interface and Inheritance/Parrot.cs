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
        public string Fly()
        {
            return "Parrot is flying";
        }
    }
}
