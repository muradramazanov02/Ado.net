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
    public class CategoryRepository : ICategoryRepository
    {
        AppDbcontext _appDbcontext=new AppDbcontext();
        public void Add(string command)
        {
           _appDbcontext.NonQuerry(command);
        }

        public void Delete(string command)
        {
            _appDbcontext.NonQuerry(command);
        }

        public Category Get(string command)
        {
            var dt= _appDbcontext.Querry(command);
            Category category = null;

            foreach (DataRow item in dt.Rows)
            {
                category = new Category
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString()
                };
            }

            return category;
        }

        public List<Category> GetAll(string command)
        {
           var dt= _appDbcontext.Querry(command);
            List<Category> categories = new List<Category>();

            foreach(DataRow item in dt.Rows)
            {
                Category category = new Category()
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                };

               categories.Add(category);
            }
            return categories;
        }

        public void Update(string command)
        {
            _appDbcontext.NonQuerry(command);

        }
    }
}
