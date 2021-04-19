using System;
using System.Collections.Generic;
using ProductMicroService.Model;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int ProductId);

        void InsertProduct(Product Product);

        void DeleteProduct(int ProductId);

        void UpdateProduct(Product Product);

        void Save();
    }
}
