using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class IngredientListViewModel
    {
        public int RecipeID { get; set; }
        public int NrOfIngredients { get; set; }

        public int NrOfInstructions { get; set; }
        public List<IngredientViewModel> ListIngredients { get; set; }

        public IngredientListViewModel()
        {
            ListIngredients = new List<IngredientViewModel>();
        }
    }
}