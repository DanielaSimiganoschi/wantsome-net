using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
   public class RecipeRepository
    {
        private readonly RecipesDBEntities db;
       

        public RecipeRepository()
        {
            db = new RecipesDBEntities();
            
        }
        public int Create(Recipe recipe)
        {
            db.Recipe.Add(recipe);
            db.SaveChanges();
            return recipe.RecipeID;

        }
    }
}
