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

        public UsedCar(string make, string model, int year, decimal price, double milage) : base(make, model, year, price)
        {
            Milage = milage;
        }
    }
}
