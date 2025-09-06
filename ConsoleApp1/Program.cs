
using ConsoleApp1;

Product p = new Product() { ProductCost = 1000, DiscountPercentage = 10 };

Console.WriteLine(p.GetDiscount());

Console.ReadKey();