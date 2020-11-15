using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class FilterRecipesViewModel
    {

        public string Name { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
         public List<SubcategoryViewModel> Subcategories { get; set; }

        public List<int> idsOfRecipes { get; set; }

        public FilterRecipesViewModel()
        {
            Categories = new List<CategoryViewModel>();
            Subcategories = new List<SubcategoryViewModel>();
            idsOfRecipes = new List<int>();
        }
    }
}