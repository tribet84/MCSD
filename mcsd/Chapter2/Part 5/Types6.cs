public class Product
{
    public decimal Price { get; set; }
}

public static class MyExtensions
{
    public static decimal Discount(this Product product)
    {
        return product.Price * .9M;
    }
}

public static class Types6
{
    public static void Run()
    {
        Product table = new Product();
        table.Price = 100;
        System.Console.WriteLine(table.Discount());
    }
}
// output
// 90.0