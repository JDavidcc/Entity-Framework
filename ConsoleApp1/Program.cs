using ConsoleApp1.Data;
using ConsoleApp1.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

var veggieSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();

if (veggieSpecial is Product)
{
    veggieSpecial.Price = 10.99M;
}
context.SaveChanges();


var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (Product p in products)
{
    Console.WriteLine($"Id:     {p.Id}");
    Console.WriteLine($"Id:     {p.Name}");
    Console.WriteLine($"Id:     {p.Price}");
    Console.WriteLine(new string('-', 20));
}