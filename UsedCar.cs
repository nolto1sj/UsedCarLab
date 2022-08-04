using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLab
{
    public class UsedCar : Car
    {
        // Constructor
        public UsedCar(string make, string model, int year, decimal price, double milage) : base(make, model, year, price)
        {
            Milage = milage;
            Condition = "Used";
        }

        // Methods
        public override string ToString()
        {
            return string.Format($"{Make,-9} {Model,-9} {Year,-5} {Condition,-5} {Price.ToString("C"),12} {Milage.ToString("N0"),8}");
        }
    }
}
