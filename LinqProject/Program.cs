using System.Net.Http.Headers;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{Id=1,Name="Bilgisayar"},
                new Category{Id=2,Name="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product{Id=1,CategoryId=1,Name="Acer Laptop",QuantityPerUnit="32 ram",UnitPrice=33333,UnitsInStock=5},
                new Product{Id=2,CategoryId=1,Name="Hp Laptop",QuantityPerUnit="16 ram",UnitPrice=11111,UnitsInStock=1},
                new Product{Id=3,CategoryId=1,Name="Asus Laptop",QuantityPerUnit="8 ram",UnitPrice=22222,UnitsInStock=3},

                new Product{Id=4,CategoryId=2,Name="Xiaomi Telefon",QuantityPerUnit="8 ram",UnitPrice=44444,UnitsInStock=6},
                new Product{Id=5,CategoryId=2,Name="Apple Telefon",QuantityPerUnit="6 ram",UnitPrice=55555,UnitsInStock=8}
            };

            //Console.WriteLine("Algorithmic-----------------");
            //foreach (var product in products)
            //{
            //    if (product.UnitPrice > 22222 && product.UnitsInStock>5)
            //    {
            //        Console.WriteLine(product.Name);
            //    }
            //}

            //Console.WriteLine("Linq-----------------");
            //var result = products.Where(x => x.UnitPrice > 22222 && x.UnitsInStock > 5);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.Name);
            //}


            GetProducts(products);

        }
        static List<Product> GetProducts (List<Product> products)
        {
            return products.Where(x => x.UnitPrice > 22222 && x.UnitsInStock > 5).ToList();
        }
    }


    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}