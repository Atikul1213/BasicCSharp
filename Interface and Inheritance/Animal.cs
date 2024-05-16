using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public virtual string Speak()
        {
            return "Animal is speaking";
        }

        public string Move()
        {
            return "Animal is moving";
        }


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
