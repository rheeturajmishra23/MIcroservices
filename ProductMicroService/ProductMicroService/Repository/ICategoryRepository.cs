using System;
using System.Collections.Generic;
using ProductMicroService.Model;

namespace ProductMicroService.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        Category GetCategoryById(int CategoryId);

        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void Save();
    }
}
