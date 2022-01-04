using CourseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Services
{
    public interface ICategoryService
    {
        List<Category> ReadAll();
        int Create(Category newcategory);
    }
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext db;
        public CategoryService()
        {
            db = new ApplicationDbContext();
        }

        public int Create(Category newcategory)
        {
            var categoryName = newcategory.Name.ToLower();
            var categoryNameExists = db.Categories.Where(x => x.Name.ToLower() == categoryName).Any();
            if (categoryNameExists)
            {
                return -1;
            }
            db.Categories.Add(newcategory);
            return  db.SaveChanges();
        }

        public List<Category>ReadAll()
        {
            return db.Categories.ToList();
        }
    }
}