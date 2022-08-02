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
        }

        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car() 
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0M;
        }

        public virtual string CarString()
        {
            return base.ToString();
        }
    }
}
