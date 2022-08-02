using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLab
{
    public static class CarLot
    {
         public static List<Car> inventory = new List<Car>()
        {
             new Car("Kia", "Rio", 2022, 19000.00m),
             new Car("Pontiac", "Vibe", 2022, 30000m),
             new Car("Acura", "CL", 2022, 24000m),
             new Car("Ford", "Explorer", 2022, 35000m)
        };
    }
}
