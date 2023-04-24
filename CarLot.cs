using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLab
{
    public static class CarLot
    {
        // Properties
        public static List<Car> OrderedInventoryList = new List<Car>();

        public static List<Car> Inventory = new List<Car>()
        {
            new Car("Kia", "Rio", 2022, 19000.00m),
            new UsedCar("Ford", "Raptor", 2019, 48367m, 34789d),
            new Car("Pontiac", "Vibe", 2022, 30000m),
            new UsedCar("Honda", "Prelude", 1998, 96850, 5999d),
            new Car("Acura", "CL", 2022, 24000m),
            new Car("Ford", "Explorer", 2022, 35000m)
        };


        // Methods
        /// <summary>
        /// Updates the OrderedInventoryList using Inventory List. This method will reflect both new inventory changes and will order inevntory based on condition provided.
        /// </summary>
        public static void UpdatedOrderedInventoryList()
        {
            OrderedInventoryList = Inventory.OrderBy(car => car.Condition).ToList();
        }

        public static void PrintCarDetails(Car carFromList)
        {
            Console.WriteLine($"\nMake: {carFromList.Make}\nModel: {carFromList.Model}\nYear: {carFromList.Year}\nCondition: {carFromList.Condition}\nPrice: {carFromList.Price.ToString("C")}");
            if (carFromList.GetType() == typeof(UsedCar))
                Console.WriteLine($"Milage: {carFromList.Milage.ToString("N0")}");
            else
                Console.WriteLine();
        }

        /// <summary>
        /// Draws a formatted inventory table to the console.
        /// </summary>
        public static void ShowCarList()
        {
            Console.WriteLine(string.Format($"{"",2}  {"MAKE",-9} {"MODEL",-9} {"YEAR",-5} {"COND.",-5} {"  PRICE",-12} {"MILAGE",8}"));
            Console.WriteLine(string.Format($"{"",2}  {"----",-9} {"-----",-9} {"----",-5} {"-----",-5} {"  -----",-12} {"------",8}"));

            int count = 0;

            UpdatedOrderedInventoryList();

            OrderedInventoryList.ForEach(car => Console.WriteLine(string.Format($"{++count,2}  ") + car.ToString()));
        }

        public static bool SellCar()
        {
            Console.WriteLine("Please provide the following details about your car:\n");
            Console.Write("Make: ");
            string make = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Milage: ");
            double milage = Convert.ToDouble(Console.ReadLine());

            Inventory.Add(new UsedCar(make, model, year, price, milage));

            Console.WriteLine("Congrats! You sold the following car:");
            
            PrintCarDetails(Inventory[Inventory.Count - 1]);

            Console.WriteLine("\nWould you now like return to see the updated inventory? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                return true;
            }
            else
                return false;
        }

        public static bool BuyCar()
        {

            Console.WriteLine($"\nWhat car would you like to buy today? (1-{OrderedInventoryList.Count})");
            int input = int.Parse(Console.ReadLine());

            PrintCarDetails(OrderedInventoryList[input - 1]);

            Console.WriteLine("\nWould you like to purchase this car? (y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                int carIndex = Inventory.FindIndex(x => x.Model.Contains(OrderedInventoryList[input - 1].Model));
                Inventory.RemoveAt(carIndex);
                UpdatedOrderedInventoryList();
                Console.Clear();
                Console.WriteLine("Excellent! Our finance department will be in touch shortly.\n");
                Console.WriteLine("Would you like to buy another car? (y/n)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    return true;
                }

                else
                    return false;
            }
            else
            {
                Console.WriteLine("\nWould you still like to buy a car? (y/n)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    // If you add a waypoint, call Console.Clear() and then ShowCarList()
                    Console.Clear();
                    return true;
                }
                else
                    return false;
            }
        }


    }
}
