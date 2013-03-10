﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositoryPatternDemo.Interfaces;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.ViewModels;

namespace RepositoryPatternDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductModel GetProduct(string name)
        {
            // Here we would write our code for accessing the database 
            // and getting the Product entity, ie using Linq or Entity Framework
            // We then create a new ProductModel instance and map the properties
            // from the returned Product entity to our new ProductModel instance
            // and return the ProductModel.
            // In this case, we're not actually connecting to the database so
            // we'll set up a method for getting some mock data
            var productData = (from p in GetMockData() where p.Name == name select p).SingleOrDefault();
            ProductModel productModel = new ProductModel();
            if (productData != null)
            {
                productModel.ID = productData.ID;
                productModel.Name = productData.Name;
                // Now we'll map the ProductModel StockQuantity property to the Product QuantityInStock property
                // This shows how we can map properties to our ViewModels in one place, in case things change in our database
                productModel.StockQuantity = productData.QuantityInStock;
            }
            return productModel;
        }

        public ProductModel CreateProduct(ProductModel product)
        {
            // Add code here for creating a new Product from our ProductModel passed in
            // In this case, again, we're not using an actual database so this will need 
            // replacing with real code when using actual data
            // The main thing here is that initially the ProductModel passed in will not 
            // have an ID property as that is generated by the database, or in this case, 
            // our mock data
            
            Product newProduct = CreateMockData(product);
            
            // Assign the new ID to the ProductModel passed in
            // In a real database you would likely need to map more fields too
            product.ID = newProduct.ID;
            return product;
        }

        public ProductModel UpdateProduct(ProductModel product)
        {
            // Add code here for updating a Product from our ProductModel passed in
            // In this case, again, we're not using an actual database so this will need 
            // replacing with real code when using actual data

            Product newProduct = CreateMockData(product);

            // This could easily just be a void instead of returning a ProductModel
            // although if the update caused any other changes on the database side
            // for the Product, we can re-map the relevant fields and pass the updated
            // ProductModel back here

            return product;
        }

        #region Mock Data Methods
        private IEnumerable<Product> GetMockData()
        {
            Product product = new Product() { ID = 1, Name = "My Product", QuantityInStock = 100 };
            List<Product> productList = new List<Product>() { product };
            return productList;
        }
        private Product CreateMockData(ProductModel product)
        {
            return new Product() { ID = 1, Name = product.Name, QuantityInStock = product.StockQuantity };
        }
        private Product UpdateMockData(ProductModel product)
        {
            return new Product() { ID = product.ID, Name = product.Name, QuantityInStock = product.StockQuantity };
        } 
        #endregion
    }
}