class Program
{

    static void Main(string[] args)
    {
        Shop shop = new Shop();
            while (true)
        {
            Console.WriteLine("\n==== Menu ====");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Sell product");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Make your choise: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Product type ( c -> Coffee, T -> Tea)");
                string productType  = Console.ReadLine().ToUpper();

                Console.Write("Product name: ");
                    string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Piece: ");
                int count = int.Parse(Console.ReadLine());

                if (productType == "C")
                {
                    shop.AddProduct(new Coffee { Name = name, Price = price, Count = count });
                }
                else if (productType == "T")
                {
                    shop.AddProduct(new Tea { Name = name, Price = price, Count = count });
                }
                else
                {
                    Console.WriteLine("You entered the wrong product type.");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Product Name to be Sold: ");
                string name = Console.ReadLine();

                Console.Write("Quantity to be sold: ");
                int count = int.Parse(Console.ReadLine());

                shop.SellProduct(name, count);
            }
            else if (choice == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection!");
            }
        }
    }
} 

class Shop
{
    private List<Product> products = new List<Product>();
    public double TotalIncome { get; private set; } = 0;

    public void AddProduct(Product product)
    {
        foreach (var p in products)
        {
            if (p.Name == product.Name)
            {
                Console.WriteLine($"Error: product called {product.Name} already exist ");
                return;
            }
        }

        products.Add(product);
        Console.WriteLine($"{product.Name} added succesfully");
    }

    public void SellProduct(string name, int count)
    {
        foreach (var p in products)
        {
            if (p.Name == name)
            {
                if (p.Count >= count)
                {
                    p.Count -= count;
                    double saleAmount = count * p.Price;
                    TotalIncome += saleAmount;

                    Console.WriteLine($"{count} piece {name} sold. Earning: {saleAmount:C}");
                    Console.WriteLine($"Total Revenue: {TotalIncome:C}");
                }
                else
                {
                    Console.WriteLine($"Insufficient stock: {p.Count} quantity available.");
                }
                return;
            }
        }

        Console.WriteLine($"The product named {name} was not found.");
    }
}
abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Count { get; set; }
}

class Coffee : Product { }

class Tea : Product { }