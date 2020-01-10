using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using model;

namespace rest.ViewModels
{
    public class ProductUserViewModel
    {
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
    }
}