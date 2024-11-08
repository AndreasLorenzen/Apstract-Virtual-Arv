using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstract_Virtual_Arv
{
     class Car : Vehicle
    {
        public Car(string brand, string model, DateTime productionDate, DateTime lastInstection) : base(brand, model, productionDate, lastInstection)
        {

        }

        public override string InstectionStatus()
        {
            if ((DateTime.Now - ProductionDate).TotalDays > 4 * 365)
                return "Car requires instection";
            return "Car does not requre instection";
        }

        public override string DisplayInfo()
        {
            return $"Car : {Brand} {Model}";
        }
    }
}
