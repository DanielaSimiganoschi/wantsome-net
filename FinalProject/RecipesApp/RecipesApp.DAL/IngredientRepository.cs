using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
   public class IngredientRepository
    {
        private readonly RecipesDBEntities db;


        public IngredientRepository()
        {
            db = new RecipesDBEntities();

        }
        public int Create(Ingredients ingredient)
        {
            db.Ingredients.Add(ingredient);
            db.SaveChanges();
            return ingredient.IngredientID;

        }

        public List<IngredientsRecipe> GetAllIngredientsByRecipeID(int id)
        {
            return db.IngredientsRecipe.Where(i => i.RecipeID == id).ToList();
        }

        public List<Ingredients>  GetNamesForRecipeIngredients(List<int> ids)
        {

            return db.Ingredients.Where(i => ids.Contains(i.IngredientID)).ToList();
        }

    }
}
