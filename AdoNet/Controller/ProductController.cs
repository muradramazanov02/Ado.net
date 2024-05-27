using Business.Services.Abstract;
using Business.Services.Concret;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Controller
{
    public class ProductController
    {
        IProductService _productService= new ProductService();

        public void AddProducts()
        {
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter product categoryId: ");
            int categoryId= int.Parse(Console.ReadLine());

            Product product = new Product()
            {
                Name = name,
                Price = price,
                CategoryId = categoryId
            };

           _productService.AddProduct(product);
        }

        public void DeleteProducts()
        {
            Console.WriteLine("Enter product Id: ");
            int id= int.Parse(Console.ReadLine());

            _productService.DeleteProduct(id);

        }

        public void UpdateProducts()
        {
            _productService.GetAllProducts();

            Console.WriteLine("Enter product Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter product categoryId: ");
            int categoryId = int.Parse(Console.ReadLine());

            Product newProduct = new Product()
            {
                Name = name,
                Price = price,
                CategoryId = categoryId

            };

            _productService.UpdateProduct(id, newProduct);
        }

        public void GetProduct()
        {
            Console.WriteLine("Enter product Id: ");
            int id = int.Parse(Console.ReadLine());

            Product product = _productService.GetProduct(id);

            Console.WriteLine($"Id:{product.Id}\nName:{product.Name}\nPrice:{product.Price}\nCategoryId:{product.CategoryId}");
           
        }

        public void GetAllProducts()
        {
            foreach(var item in _productService.GetAllProducts())
            {
                Console.WriteLine($"Id:{item.Id}\nName:{item.Name}\nPrice:{item.Price}\nCategoryId:{item.CategoryId}");
            }
        }
    }
}
