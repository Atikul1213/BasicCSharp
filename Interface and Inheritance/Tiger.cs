using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Tiger : Animal
    {
        public override string Move()
        {
            return "by walking";
        }

        public override string Speak()
        {
            return "Halum Halum";
        }
         

    }
}
