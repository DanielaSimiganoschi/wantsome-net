using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
    public class CategoryRepository
    {
        private readonly RecipesDBEntities db;


        public CategoryRepository()
        {
            db = new RecipesDBEntities();

        }
        public List<CategoryRecipe> GetAllCategoriesByRecipeID(int id)
        {
            return db.CategoryRecipe.Where(i => i.RecipeID == id).ToList();
        }
        public List<Category> GetNamesForRecipeCategories(List<int> ids)
        {

            return db.Category.Where(i => ids.Contains(i.CategoryID)).ToList();
        }
    }
}
