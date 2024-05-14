using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_example
{
    public class Engine
    {

        public string Brand { get; set;}
        public string No { get; set; }
        public string HorsePower { get; set; }
        public bool status { get; set; }

        public Engine(string _brand, string _no,string _horsePower)
        {
            Brand = _brand; 
            No = _no;
            HorsePower = _horsePower;
        }

        public string On()
        {
            if (status)
            {
                return "Engine already started";
            }
            status = true;
            return "Engine has started";
        }

        public string Off()
        {
            if (status)
            {
                status = false;
                return "Engine has stop successfully";
            }
            return "Engine already stop.";
        }

    }
}
