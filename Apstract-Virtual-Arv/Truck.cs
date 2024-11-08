using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstract_Virtual_Arv
{
    class Truck : Vehicle
    {
        public Truck (string brand, string model, DateTime ProductionDate, DateTime LastInspection)
            : base(brand, model, ProductionDate, LastInspection) { }

        public override string InstectionStatus()
        {
            if ((DateTime.Now - ProductionDate).TotalDays > 1 * 365)
            {

                return $"Truck requres instection";
            }
            return $"Truck does not reqire instiection";
        }
        public override string DisplayInfo()
        {
            return $" Truck {Brand} {Model}";
        }
    }
}
