using System;
string currentItem = "";
double Sum = 0;
Dictionary<string, double> shoppingList = new Dictionary<string, double>()
{
    {"Eggs" , 3.99},
    {"Pop" , 6.99},
    {"Squishmellow" , 24.99},
    {"Pumpkin" , 5.49 },
    {"Hot Dogs" , 15.99},
    {"Bannana Bread" , 35.99},
    {"Cheese" , 150.50},
    {"Grapes", 2.99 },
};
foreach (var shopping in shoppingList)
{
    Console.WriteLine(shopping);
}
List<string> Useritems = new List<string>();



bool orderAgain = false;
do
{
    Console.WriteLine("What would you like to order?");
    string currentItem = Console.ReadLine();
    Useritems.Add(currentItem);
    Sum = Sum + currentItem
    Validate();
    Console.WriteLine("Would you like to order another item? (y/n)?");
    string input = Console.ReadLine();
    orderAgain = input.ToLower() == "y";
} while (orderAgain == true);



    Console.WriteLine$" You had {Useritems} and to totale came to {Sum}";

Console.ReadKey();

void Validate(shoppingList currentItem)
{
    if (!shoppingList.ContainsKey(currentItem)
    {
        Console.WriteLine($"We do not have {currentItem} Please select from the list.");
    }
}