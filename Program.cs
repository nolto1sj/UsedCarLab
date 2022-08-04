using UsedCarLab;

CarLot.inventory = CarLot.inventory.OrderBy(car => car.Condition).ToList();

Console.WriteLine(string.Format($"{"",2}  {"MAKE",-9} {"MODEL",-9} {"YEAR",-5} {"COND.",-5} {"  PRICE",-12} {"MILAGE",8}"));
Console.WriteLine(string.Format($"{"",2}  {"----",-9} {"-----",-9} {"----",-5} {"-----",-5} {"  -----",-12} {"------",8}"));

int count = 0;

CarLot.inventory.ForEach(car =>
{
    count++;
    Console.WriteLine(string.Format($"{count,2}  ") + car.ToString());
});