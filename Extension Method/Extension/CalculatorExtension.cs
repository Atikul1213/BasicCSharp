using Extension_Method.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method.Extension
{
    public static class CalculatorExtension
    {
        public static int Multiply( this Calculator cal,int num1,int num2)
        {
            return num1 * num2;
        }

    }
}
