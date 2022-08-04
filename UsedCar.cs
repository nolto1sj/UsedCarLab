using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLab
{
    public class UsedCar : Car
    {
        public double Milage { get; set; }
        public new string Condition = "Used";

        public UsedCar(string make, string model, int year, decimal price, double milage) : base(make, model, year, price)
        {
            Milage = milage;
        }

        public override string ToString() // Lisa was right, I cannot read
        {
            return string.Format($"{Make,-9} {Model,-9} {Year,-5} {Condition,-5} {Price.ToString("C"),12} {Milage.ToString("N0"),8}");
        }
    }
}
