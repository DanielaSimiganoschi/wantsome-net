using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic.BusinessEntities
{
    public class IngredientsRecipeBL
    {
        public int IngredientsRecipeID { get; set; }
        public string Quantity { get; set; }
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public string Name { get; set; }
    }
}
