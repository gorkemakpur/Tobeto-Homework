namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Test";
            product1.Price = 10;
            product1.UnitsInStock = 5;

            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Test-2-",
                Price = 10,
                UnitsInStock = 5
            };
            //PascalCase  //camelCase  case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            int sayi = 100;
            Console.WriteLine(sayi);

            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 5);
            int toplamaSonucu = productManager.Topla(3, 5);
            Console.WriteLine(toplamaSonucu*2);
        }
    }
}