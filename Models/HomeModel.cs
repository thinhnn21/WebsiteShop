using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMitilShop.Context;

namespace WebMitilShop.Models
{
    public class HomeModel
    {
        public List<Category> ListCategory { get; set; }
        public List<Product> ListProduct { get; set; }
        public   Product OneProduct { get; set; } 
        public Category OneCategory { get; set; }


    }
}