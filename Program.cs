﻿using UsedCarLab;

bool continueLoop = true;

Console.WriteLine("Welcome to the Car Lot!\n");

while(continueLoop)
{
    CarLot.ShowCarList();
    Console.WriteLine("\nWhat car would you like to buy today?");
    int input = int.Parse(Console.ReadLine());

    CarLot.PrintCarDetails(CarLot.OrderedInventoryList[input - 1]);

    Console.WriteLine("Would you like to purchase this car? y/n ");
    if (Console.ReadKey().Key == ConsoleKey.Y)
    {
        int carIndex = CarLot.Inventory.FindIndex(x => x.Model.Contains(CarLot.OrderedInventoryList[input - 1].Model));
        CarLot.Inventory.RemoveAt(carIndex);
        CarLot.UpdatedOrderedInventoryList();
        Console.Clear();
        Console.WriteLine("Excellent! Our finance department will be in touch shortly.\n");
        Console.WriteLine("Would you like to buy another car? (y/n)");
        if (Console.ReadKey().Key == ConsoleKey.Y)
            Console.Clear();
        else
            continueLoop = false;
    }
    else
    {
        continueLoop = false;
    }
}

Console.WriteLine();
Console.WriteLine("Thank you for shopping with us!");




