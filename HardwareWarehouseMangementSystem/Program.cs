using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementSystemAPI;

namespace HardwareWarehouseMangementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class HardwareItem : IEntityPrimaryProperties, IEntityAdditionalProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
    }

    public interface IDrill
    {
        string DrillBrandName { get; set; }

    }

    public class Drill : HardwareItem, IDrill
    {
        public string DrillBrandName { get; set; }

    }



    public interface ILadder
    {
        string 
    }

}
