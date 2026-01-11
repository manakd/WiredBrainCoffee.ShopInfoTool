using System.Security.Cryptography.X509Certificates;
using WiredBrainCoffee.ShopInfoTool.Data;

Console.WriteLine("-------------------------------------"); 
Console.WriteLine(" Wired Brain Coffee - Shop Info Tool ");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
Console.WriteLine("Commands:");
Console.WriteLine("  shops  show coffeeshops");
Console.WriteLine("  quit   exit application");

while (true)
{
    var command = Console.ReadLine();
    if (string.Equals("quit",command,StringComparison.OrdinalIgnoreCase))
    {
        break; 
    }
    else if (string.Equals("shops", command, StringComparison.OrdinalIgnoreCase))
    {
        var dataProvider = new CoffeeShopDataProvider();
        var coffeeShops = dataProvider.LoadShops();

        foreach (var coffeeShop in coffeeShops)
        {
            Console.WriteLine(coffeeShop);
        }
    }
    else
    {
        Console.WriteLine($"Invalid command: {command}");
    }
}
