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
    public class CategoryController
    {
        ICategoryService _categoryService = new CategoryService();

        public void AddCategory()
        {
            Console.WriteLine("Enter category Name: ");
            string name = Console.ReadLine();


            Category category = new Category()
            {
               Name=name
            };

            _categoryService.AddCategory(category);
        }

        public void DeleteCategory()
        {
            Console.WriteLine("Enter category id: ");
            int id = int.Parse(Console.ReadLine());

            _categoryService.DeleteCategory(id);
        }

        public void UpdateCategory()
        {
            GetAllCategory();
            Console.WriteLine("Enter category id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter category name: ");
            string name = Console.ReadLine();

            Category newCategory = new Category()
            {
                Name = name
            };


            _categoryService.UpdateCategory(id, newCategory);
        }

        public void GetAllCategory()
        {
            foreach (var item in _categoryService.GetAllCategories())
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }

        public void GetCategory()
        {
            Console.WriteLine("Enter category id: ");
            int id = int.Parse(Console.ReadLine());

            Category category = _categoryService.GetCategory(id);

            Console.WriteLine($"{category.Id} - {category.Name}");
        }
    }
}
