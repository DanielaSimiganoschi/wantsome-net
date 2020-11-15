using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
    public class SubcategoryRepository
    {
        private readonly RecipesDBEntities db;


        public SubcategoryRepository()
        {
            db = new RecipesDBEntities();

        }
        public List<SubcategoryRecipe> GetAllSubCategoriesByRecipeID(int id)
        {
            return db.SubcategoryRecipe.Where(i => i.RecipeID == id).ToList();
        }
        public List<Subcategory> GetNamesForRecipeSubCategories(List<int> ids)
        {

            return db.Subcategory.Where(i => ids.Contains(i.SubcategoryID)).ToList();
        }
    }
}
