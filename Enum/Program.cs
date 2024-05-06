using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        public enum Season
        {
            Spring,
            Summer,
            Antumn,
            Winter
        }

        static void Main(string[] args)
        {
            var season = Season.Antumn;
            switch (season)
            {
                case Season.Antumn:
                    Console.WriteLine("It is antumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("it is Spring");
                    break;
                default:
                    Console.WriteLine("It is other");
                    break;
            }

        }
    }
}
