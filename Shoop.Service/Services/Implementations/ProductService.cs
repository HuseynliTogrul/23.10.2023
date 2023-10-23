

using System;
using Shoop.Core.Models;
using Shoop.Service.Extention;
using Shoop.Service.Services.Interfaces;

namespace Shoop.Service.Services.Implementations
{
    public class ProductService : IProductService
    {
        Product[] products = { }; 
        public void CreateProduct()
        {
            Console.WriteLine("Add Name:");
            string Name = Console.ReadLine();
            Name = Name.Str();
            Console.WriteLine("Add Price:");
            int.TryParse(Console.ReadLine(),out int Price);
            Console.WriteLine("Add Category:");
            string Category = Console.ReadLine();
            Category = Category.Str();
            Console.WriteLine("Add StockCount:");
            int.TryParse(Console.ReadLine(), out int StockCount);

            Product product = new Product();
            product.Name = Name;
            product.Price = Price;
            product.StockCount = StockCount;
            product.Category = Category;

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

            Console.WriteLine("Created succesfull :) ");
        }

        public void ShowProduct()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void ProductGetById()
        {
            Console.WriteLine("Add Id:");
            int.TryParse(Console.ReadLine().Trim(),out int id);
            Product result = null;
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    result = product;
                    break;
                }
            }
            if (result == null)
            {
                Console.WriteLine($"product is not with id {id}");
            }
            else
            {
                Console.WriteLine(products);
            }
        }
    }
}
