using System;
using System.Collections.Generic;
using System.Linq;
using ProductMicroservice.DBContexts;
using ProductMicroService.Model;

namespace ProductMicroService.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ProductContext _dbContext;
        public CategoryRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int CategoryId)
        {
            return _dbContext.Categories.Find(CategoryId);
        }

        public void InsertCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _dbContext.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
