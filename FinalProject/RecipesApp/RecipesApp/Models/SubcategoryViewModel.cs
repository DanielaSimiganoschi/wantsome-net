using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class SubcategoryViewModel
    {
        public bool IsSelected { get; set; }
        public int SubcategoryID { get; set; }
        public string Name { get; set; }
    }
}