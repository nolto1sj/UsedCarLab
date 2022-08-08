using UsedCarLab;

Console.BackgroundColor = ConsoleColor.DarkGreen; 
Console.ForegroundColor = ConsoleColor.Yellow;

bool continueLoop = true;

Console.WriteLine("Welcome to the Car Lot!\n");

while(continueLoop)
{
    CarLot.ShowCarList();

    Console.WriteLine("What would you like to do? 1 = Buy a car / 2 = Sell a car / 0 = Leave the lot");
    ConsoleKey actionKey = Console.ReadKey().Key;

    switch (actionKey)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            continueLoop = CarLot.BuyCar();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            continueLoop = CarLot.SellCar();
            break;
        case ConsoleKey.D0:
        case ConsoleKey.NumPad0:
            continueLoop = false;
            break;
        default:
            Console.WriteLine("Please enter a valid input.");
            break;
    }

    
}

Console.WriteLine();
Console.WriteLine("\nThank you for shopping with us!");