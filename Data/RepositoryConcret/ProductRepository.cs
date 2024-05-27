using Core.Models;
using Core.RepositoryAbstract;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcret
{
    public class ProductRepository : IProductRepository
    {
        AppDbcontext _appDbcontext= new AppDbcontext();
        public void Add(string command)
        {
            _appDbcontext.NonQuerry(command);
        }

        public void Delete(string command)
        {
            _appDbcontext.NonQuerry(command);
        }

        public Product Get(string command)
        {
            var dt =_appDbcontext.Querry(command);
            Product product = null;

            foreach(DataRow item in dt.Rows)
            {
                product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = double.Parse(item[2].ToString()),
                    CategoryId = int.Parse(item[3].ToString())
                };
            }
            return product;
        }

        public List<Product> GetAll(string command)
        {
            var dt= _appDbcontext.Querry(command);
            List<Product> products = new List<Product>();

            foreach(DataRow item in dt.Rows)
            {
                Product product = new Product
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = double.Parse(item[2].ToString()),
                    CategoryId = int.Parse(item[3].ToString())
                };

                products.Add(product);
            }
            return products;
        }

        public void Update(string command)
        {
            _appDbcontext.NonQuerry(command);
        }
    }
}
