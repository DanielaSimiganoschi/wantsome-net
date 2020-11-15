using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class CategoryViewModel
    {
        public bool IsSelected { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}