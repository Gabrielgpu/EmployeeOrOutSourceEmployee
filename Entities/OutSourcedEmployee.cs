using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_5.Entities
{
    public class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return Hours * ValuePerHour + (AdditionalCharge * 1.10);
        }

    }
}