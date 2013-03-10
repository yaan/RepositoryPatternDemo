using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternDemo.ViewModels
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
    }
}