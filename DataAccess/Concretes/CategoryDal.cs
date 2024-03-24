using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Programming"},
            new Category{CategoryId=2,CategoryName="Design"},
        };
    }
    public List<Category> GetAll()
    {
        return _categories;
    }
    public void Add(Category category)
    {
        _categories.Add(category);

        Console.WriteLine("Category Added");
    }
    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);

        categoryToUpdate.CategoryName = category.CategoryName;

        Console.WriteLine("Category Updated");
    }
    public void Delete(Category category)
    {
        Category categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);

        _categories.Remove(categoryToDelete);

        Console.WriteLine("Category Deleted");
    }

}
