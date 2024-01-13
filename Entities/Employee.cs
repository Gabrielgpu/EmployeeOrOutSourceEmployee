using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_5.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }


        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Name + " - $" + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}