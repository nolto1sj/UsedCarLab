using UsedCarLab;

Console.WriteLine("Welcome to the Car Lot!");
Console.WriteLine();
Console.WriteLine("What car would you like to buy today? ");

CarLot.ShowCarList();

int input = int.Parse(Console.ReadLine());


CarLot.PrintCarDetails(CarLot.OrderedInventoryList[input - 1]);

Console.WriteLine("Would you like to purchase this car? y/n ");
if (Console.ReadKey().Key == ConsoleKey.Y)
{
    int carIndex = CarLot.Inventory.FindIndex(x => x.Model.Contains(CarLot.OrderedInventoryList[input - 1].Model));
    CarLot.Inventory.RemoveAt(carIndex);

    CarLot.UpdatedOrderedInventoryList();
    CarLot.ShowCarList();
    Console.ReadLine();
}

else
{

}
