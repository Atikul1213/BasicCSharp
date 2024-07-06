using Inheritance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Transport
{
    public class Roket : IFlyable
    {
        public string Fly()
        {
            return "Roket is Flying";
        }
    }
}
