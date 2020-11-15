using RecipesApp.BusinessLogic.BusinessEntities;
using RecipesApp.DAL;
using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic
{
    public class RecipeService
    {

        private readonly GenericRepository<CategoryRecipe> categoryRecipeRepository;
        private readonly GenericRepository<SubcategoryRecipe> subcategoryRecipeRepository;
        private readonly RecipeRepository recipeRepository;
        private readonly GenericRepository<Recipe> recipeRepositoryG;
        private readonly CategoryRepository catRepository;
        private readonly SubcategoryRepository subcatRepository;

        public RecipeService()
        {
            recipeRepository = new RecipeRepository();
            categoryRecipeRepository = new GenericRepository<CategoryRecipe>();
            subcategoryRecipeRepository = new GenericRepository<SubcategoryRecipe>();
            recipeRepositoryG = new GenericRepository<Recipe>();
            catRepository = new CategoryRepository();
            subcatRepository = new SubcategoryRepository();
        }

        public int Create(RecipeBL recipe, List<CategoryRecipeBL> listOfCategories, List<SubcategoryRecipeBL> listOfSubcategories)
        {

            RatingService r = new RatingService();
            var ratingID = r.CreateEmptyRating();

            var recipeDAL = new Recipe()
            {
                Name = recipe.Name,
                Description = recipe.Description,
                LongDescription = recipe.LongDescription,
                RatingID = ratingID,
                PictureLocation = recipe.PictureLocation,
                PrepTime = recipe.PrepTime,
                CookTime = recipe.CookTime

            };
            int id = recipeRepository.Create(recipeDAL);

            List<CategoryRecipe> categoriesRecipe = new List<CategoryRecipe>();
            List<SubcategoryRecipe> subcategoriesRecipe = new List<SubcategoryRecipe>();

            foreach (var c in listOfCategories)
            {
                categoriesRecipe.Add(new CategoryRecipe
                {
                    CategoryID = c.CategoryID,
                    RecipeID = id
                });
            }

            foreach (var c in categoriesRecipe)
            {
                categoryRecipeRepository.Create(c);

            }

            foreach (var s in listOfSubcategories)
            {
                subcategoriesRecipe.Add(new SubcategoryRecipe
                {
                    SubcategoryID = s.SubcategoryID,
                    RecipeID = id
                });
            }

            foreach (var s in subcategoriesRecipe)
            {
                subcategoryRecipeRepository.Create(s);

            }

            return id;
        }

        public List<RecipeBL> GetAllRecipes()
        {
            var listAllRecipes = recipeRepositoryG.GetAll();
            var listAllRecipesBL = new List<RecipeBL>();

            foreach (var i in listAllRecipes)
            {
                listAllRecipesBL.Add(new RecipeBL()
                {
                    RecipeID = i.RecipeID,
                    CookTime = i.CookTime,
                    Description = i.Description,
                    LongDescription = i.LongDescription,
                    Name = i.Name,
                    RatingID = i.RatingID,
                    PictureLocation = i.PictureLocation,
                    PrepTime = i.PrepTime
                });
            }

            return listAllRecipesBL;
        }

        public RecipeBL GetRecipeByID(int id)
        {
            var recipe = recipeRepositoryG.Get(id);
            var recipeBL = new RecipeBL()
            {
                RecipeID = recipe.RecipeID,
                CookTime = recipe.CookTime,
                Description = recipe.Description,
                LongDescription = recipe.LongDescription,
                Name = recipe.Name,
                RatingID = recipe.RatingID,
                PictureLocation = recipe.PictureLocation,
                PrepTime = recipe.PrepTime
            };
            return recipeBL;
        }

        public void DeleteRecipeByID(int id)
        {
            recipeRepositoryG.Delete(id);
        }

        public void Update(RecipeBL recipe, List<CategoryRecipeBL> listOfCategories, List<SubcategoryRecipeBL> listOfSubcategories)
        {
            var recipeDAL = new Recipe()
            {
                Name = recipe.Name,
                Description = recipe.Description,
                LongDescription = recipe.LongDescription,
                RatingID = recipe.RatingID,
                PictureLocation = recipe.PictureLocation,
                PrepTime = recipe.PrepTime,
                CookTime = recipe.CookTime,
                RecipeID = recipe.RecipeID

            };
            recipeRepositoryG.Update(recipeDAL);

            List<CategoryRecipe> categoriesRecipe = new List<CategoryRecipe>();
            List<SubcategoryRecipe> subcategoriesRecipe = new List<SubcategoryRecipe>();

            foreach (var c in listOfCategories)
            {
                categoriesRecipe.Add(new CategoryRecipe
                {
                    CategoryID = c.CategoryID,
                    RecipeID = recipe.RecipeID
                });
            }
            var listOfAllCategoriesForRecipe = catRepository.GetAllCategoriesByRecipeID(recipe.RecipeID);
            List<CategoryRecipe> categoriesToInsert = new List<CategoryRecipe>();

            foreach(var c in categoriesRecipe)
            {
                  if(!(listOfAllCategoriesForRecipe.Any(prod => prod.CategoryID == c.CategoryID & prod.RecipeID == c.RecipeID)))
                {
                    categoriesToInsert.Add(c);
                } 

            }

            foreach (var c in listOfAllCategoriesForRecipe)
            {
                if (!(categoriesRecipe.Any(prod => prod.CategoryID == c.CategoryID & prod.RecipeID == c.RecipeID)))
                {
                    categoryRecipeRepository.Delete(c.CategoryRecipeID);
                }

            }

            foreach (var c in categoriesToInsert)
            {
                categoryRecipeRepository.Create(c);

            }


            foreach (var s in listOfSubcategories)
            {
                subcategoriesRecipe.Add(new SubcategoryRecipe
                {
                    SubcategoryID = s.SubcategoryID,
                    RecipeID = recipe.RecipeID
                });
            }


            var listOfAllSubcategoriesForRecipe = subcatRepository.GetAllSubCategoriesByRecipeID(recipe.RecipeID);
            List<SubcategoryRecipe> subcategoriesToInsert = new List<SubcategoryRecipe>();

            foreach (var c in subcategoriesRecipe)
            {
                if (!(listOfAllSubcategoriesForRecipe.Any(prod => prod.SubcategoryID == c.SubcategoryID & prod.RecipeID == c.RecipeID)))
                {
                    subcategoriesToInsert.Add(c);
                }

            }

            foreach (var c in listOfAllSubcategoriesForRecipe)
            {
                if (!(subcategoriesRecipe.Any(prod => prod.SubcategoryID == c.SubcategoryID & prod.RecipeID == c.RecipeID)))
                {
                    subcategoryRecipeRepository.Delete(c.SubcategoryRecipeID);
                }

            }

            foreach (var s in subcategoriesToInsert)
            {
                subcategoryRecipeRepository.Create(s);

            }

        
        }

        public List<int> GetAllRecipeIDSThatAreInCategories(List<int> idSOfCategories)
        {
            var allRecipes = recipeRepositoryG.GetAll();
            var allRecipeIDS = new List<int>();
            foreach(var r in allRecipes)
            {
                var allCategoriesForRecipe=  catRepository.GetAllCategoriesByRecipeID(r.RecipeID);
                var allIDsOfCategoriesForRecipe = new List<int>();
                foreach(var i in allCategoriesForRecipe)
                {
                    allIDsOfCategoriesForRecipe.Add(i.CategoryID);
                }

                bool result = idSOfCategories.All(i => allIDsOfCategoriesForRecipe.Contains(i));
                if(result == true)
                {
                    allRecipeIDS.Add(r.RecipeID);
                }
            }

            return allRecipeIDS;
        }


        public List<int> GetAllRecipeIDSThatAreInSubcategories(List<int> idSOfSubcategories)
        {
            var allRecipes = recipeRepositoryG.GetAll();
            var allRecipeIDS = new List<int>();
            foreach (var r in allRecipes)
            {
                var allSubcategoriesForRecipe = subcatRepository.GetAllSubCategoriesByRecipeID(r.RecipeID);
                var allIDsOfSubcategoriesForRecipe = new List<int>();
                foreach (var i in allSubcategoriesForRecipe)
                {
                    allIDsOfSubcategoriesForRecipe.Add(i.SubcategoryID);
                }

                bool result = idSOfSubcategories.All(i => allIDsOfSubcategoriesForRecipe.Contains(i));
                if (result == true)
                {
                    allRecipeIDS.Add(r.RecipeID);
                }
            }

            return allRecipeIDS;

        }

        public List<int> GetRecipesIDSThatHaveStringInName(string name, IEnumerable<int> listIDS)
        {
            var listOfIDs = new List<int>();
            foreach(int i in listIDS)
            {
                var recipe = recipeRepositoryG.Get(i);
                var index = recipe.Name.IndexOf(name);
                if(index != -1)
                {
                    listOfIDs.Add(recipe.RecipeID);
                }
            }

            return listOfIDs;
        }
    }
}
