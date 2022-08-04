using UsedCarLab;

Console.WriteLine("Welcome to the Car Lot!");
Console.WriteLine();

CarLot.ShowCarList();

int input = int.Parse(Console.ReadLine());

CarLot.PrintCarDetails(CarLot.OrderedInventoryList[input - 1]);

Console.WriteLine("Would you like to purchase this car? y/n ");
if (Console.ReadKey().Key == ConsoleKey.Y)
{

}
else
{

}