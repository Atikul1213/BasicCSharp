using Inheritance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Eagle : Animal, IFlyable
    {
        public string Call()
        {
            return "Eagle is calling";
        }

        public override string Fly()
        {
            return "Eagle is flying";
        }


        public override  string Speak()
        {
            return "Ko ko ko";
        }



    }
}
