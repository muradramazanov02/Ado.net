using Business.Services.Abstract;
using Core.Models;
using Core.RepositoryAbstract;
using Data.RepositoryConcret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concret
{
    public class ProductService:IProductService
    {
        IProductRepository _productRepository = new ProductRepository();
        public void AddProduct(Product product)
        {
            string command = $"Insert Into Product([Name],Price,CategoryId) values('{product.Name}',{product.Price},{product.CategoryId})";
            _productRepository.Add(command);
        }

        public void DeleteProduct(int id)
        {
            string command = $"DELETE FROM Product WHERE Id = {id}";
            _productRepository.Delete(command);
        }

        public List<Product> GetAllProducts()
        {
            string command = "SELECT * FROM Product";
            return _productRepository.GetAll(command);
        }

        public Product GetProduct(int id)
        {
            string command = $"SELECT * FROM Product WHERE Id = {id}";
            return _productRepository.Get(command);
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            string command = $"SELECT * FROM Product WHERE Id = {id}";
            Product product = _productRepository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Name = newProduct.Name;

            string updateCommand = $"UPDATE Product SET [Name] = '{product.Name}',[Price]={product.Price},CategoryId={product.CategoryId} Where Id={id}";
            _productRepository.Update(updateCommand);
        }
    }
}
