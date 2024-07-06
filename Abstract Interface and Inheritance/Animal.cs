using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Animal
    {
        public virtual string Speak()
        {
            return "Animal is speaking";
        }

        public abstract string Move();


        public string Eat()
        {
            return "Animal is eating";
        }

        public virtual string Fly()
        {
            return "Animal is flying";
        }
       
    }
}
