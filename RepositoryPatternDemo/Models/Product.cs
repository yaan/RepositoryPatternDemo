using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternDemo.Models
{

    /// <summary>
    /// This class will represent your database table called Products 
    /// (the standard is to pluralize the database table, 
    /// but make the class/entity in your code singular, 
    /// representing a single row in the database)
    /// </summary>
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
    }
}