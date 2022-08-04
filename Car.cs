using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLab
{
    public class Car
    {
       public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model; 
            Year = year;  
            Price = price;
            Condition = "New";
        }

        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }

        public Car() 
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0M;
        }

        public override string ToString() // Lisa was right, I cannot read
        {
            return string.Format($"{Make,-9} {Model,-9} {Year,-5} {Condition,-5} {Price.ToString("C"),12}");
        }
    }
}
