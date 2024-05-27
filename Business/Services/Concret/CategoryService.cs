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
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository = new CategoryRepository();
        public void AddCategory(Category category)
        {
            string command = $"Insert Into Category([Name]) values('{category.Name}')";
            _categoryRepository.Add(command);
        }

        public void DeleteCategory(int id)
        {
            string command = $"DELETE FROM Category WHERE Id = {id}";
            _categoryRepository.Delete(command);
        }

        public List<Category> GetAllCategories()
        {
            string command = "SELECT * FROM Category";
            return _categoryRepository.GetAll(command);
        }

        public Category GetCategory(int id)
        {
            string command = $"SELECT * FROM Category WHERE Id = {id}";
            return _categoryRepository.Get(command);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            string command = $"SELECT * FROM Category WHERE Id = {id}";
            Category category = _categoryRepository.Get(command);

            if (category == null) throw new NullReferenceException();

            category.Name = newCategory.Name;

            string updateCommand = $"UPDATE Category SET Name = '{category.Name}' Where Id={id}";
            _categoryRepository.Update(updateCommand);
        }
    }
}
