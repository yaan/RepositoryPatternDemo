using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryPatternDemo.ViewModels;

namespace RepositoryPatternDemo.Interfaces
{
    public interface IProductRepository
    {
        ProductModel GetProduct(string name);
        ProductModel CreateProduct(ProductModel product);
        ProductModel UpdateProduct(ProductModel product);
    }
}
