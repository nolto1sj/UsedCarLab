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
             new Car("Ford", "Explorer", 2022, 35000m),
             new UsedCar("Ford", "Raptor", 2019, 48367m, 34789d),
             new UsedCar("Honda", "Prelude", 1998, 96850, 5999d)
        };

        public static void ShowCarList()
        {
            inventory = inventory.OrderBy(car => car.Condition).ToList();

            Console.WriteLine(string.Format($"{"",2}  {"MAKE",-9} {"MODEL",-9} {"YEAR",-5} {"COND.",-5} {"  PRICE",-12} {"MILAGE",8}"));
            Console.WriteLine(string.Format($"{"",2}  {"----",-9} {"-----",-9} {"----",-5} {"-----",-5} {"  -----",-12} {"------",8}"));

            int count = 0;

            inventory.ForEach(car =>
            {
                count++;
                Console.WriteLine(string.Format($"{count,2}  ") + car.ToString());
            });
        }
    }
}
