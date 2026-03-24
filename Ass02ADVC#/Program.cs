namespace Ass02ADVC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           
            #region catalog
            List<Product> catalog = new()
{
    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
    new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
    new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
    new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
    new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
    new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
    new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
    new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
    new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
    new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
};
            #endregion
            #region Task01
            //Predicate<Product> filter = prod => prod.Category == "Electronics";
            ////List<Product> products = SearchProducts(catalog, filter);
            ////Console.WriteLine("------Electronics----------");
            ////foreach(Product p in products)
            ////{
            ////    Console.WriteLine($"{p.Name}-${p.Price}(stock: {p.Stock})");
            ////}
            //filter = prod => prod.Price < 50;
            ////List<Product> products = SearchProducts(catalog, filter);
            ////Console.WriteLine("------Under $50----------");
            ////foreach (Product p in products)
            ////{
            ////    Console.WriteLine($"{p.Name}-${p.Price}(stock: {p.Stock})");
            ////}
            //filter = prod => prod.Stock > 0;
            ////List<Product> products = SearchProducts(catalog, filter);
            ////Console.WriteLine("--------In stock--------");
            ////foreach (Product p in products)
            ////{
            ////    Console.WriteLine($"{p.Name}-${p.Price}(stock: {p.Stock})");
            ////}
            //filter = prod => prod.Category == "Clothing"&&prod.Price<100;
            ////List<Product> products = SearchProducts(catalog, filter);
            ////Console.WriteLine("--------In stock--------");
            ////foreach (Product p in products)
            ////{
            ////    Console.WriteLine($"{p.Name}-${p.Price}(stock: {p.Stock})");
            ////}
            #endregion
            #region Task03.1
            //Action<Product> action = prod => Console.WriteLine($"{prod.Name}-${prod.Price}");
            //Console.WriteLine("-----------Short Report-----------");
            //PrintReport(catalog, action);
            //action = prod => Console.WriteLine($"[{prod.Category}] {prod.Name} | price : ${prod.Price} | stock : {prod.Stock}");
            //Console.WriteLine("-----------Delited Report-----------");
            //PrintReport(catalog, action);
            //i choose action becouse the functions is void 
            #endregion
        }
        #region HelperFunction
        static List<Product> SearchProducts(List<Product> products, Predicate<Product> filter)
        {
            return products.FindAll(filter);
        }
        static void PrintReport(List<Product> products,Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }
        #endregion
    }
}
