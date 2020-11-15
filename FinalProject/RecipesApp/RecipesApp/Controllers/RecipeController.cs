using RecipesApp.BusinessLogic;
using RecipesApp.BusinessLogic.BusinessEntities;
using RecipesApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipesApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeService recipeService;
        private readonly CategoryService categoryService;
        private readonly SubcategoryService subcategoryService;
        private readonly IngredientService ingredientService;
        private readonly InstructionsService instructionsService;
        private readonly RatingService ratingService;

        public RecipeController()
        {
            recipeService = new RecipeService();
            categoryService = new CategoryService();
            subcategoryService = new SubcategoryService();
            ingredientService = new IngredientService();
            instructionsService = new InstructionsService();
            ratingService = new RatingService();

        }

        // GET: Recipe
        public ActionResult Index()
        {
            var listOfRecipesBL = recipeService.GetAllRecipes();
            List<RecipeViewModel> listOfRecipes = new List<RecipeViewModel>();
            foreach (var i in listOfRecipesBL)
            {
                listOfRecipes.Add(new RecipeViewModel()
                {
                    RecipeID = i.RecipeID,
                    Name = i.Name,
                    Description = i.Description,
                    PictureLocation = i.PictureLocation,
                    CookTime = i.CookTime,
                    PrepTime = i.PrepTime
                });
            }
            return View(listOfRecipes);
        }

        [HttpGet]
        public ActionResult Create()
        {

            var x = new RecipeViewModel();
            var categories = categoryService.GetAllCategories();
            var listOfCategories = new List<CategoryViewModel>();

            var subcategories = subcategoryService.GetAllSubcategories();
            var listOfSubcategories = new List<SubcategoryViewModel>();

            foreach (var c in categories)
            {
                listOfCategories.Add(new CategoryViewModel
                {
                    IsSelected = false,
                    CategoryID = c.CategoryID,
                    Name = c.Name

                });
            }

            foreach (var i in listOfCategories)
            {
                x.Categories.Add(i);
            }

            foreach (var c in subcategories)
            {
                listOfSubcategories.Add(new SubcategoryViewModel
                {
                    SubcategoryID = c.SubcategoryID,
                    Name = c.Name

                });
            }

            foreach (var i in listOfSubcategories)
            {
                x.Subcategories.Add(i);
            }

            return View(x);

        }

        [HttpPost]
        public ActionResult Create(RecipeViewModel recipe)
        {
            RecipeBL recipeBL = new RecipeBL
            {
                Description = recipe.Description,
                Name = recipe.Name,
                LongDescription = recipe.LongDescription,
                PictureLocation = recipe.PictureLocation,
                PrepTime = recipe.PrepTime,
                CookTime = recipe.CookTime
            };

            List<CategoryRecipeBL> categories = new List<CategoryRecipeBL>();
            foreach (var i in recipe.Categories)
            {
                if (i.IsSelected == true)
                {
                    categories.Add(new CategoryRecipeBL
                    {
                        CategoryID = i.CategoryID
                    });
                }

            }

            List<SubcategoryRecipeBL> subcategories = new List<SubcategoryRecipeBL>();
            foreach (var i in recipe.Subcategories)
            {
                if (i.IsSelected == true)
                {
                    subcategories.Add(new SubcategoryRecipeBL
                    {
                        SubcategoryID = i.SubcategoryID
                    });
                }
            }
            int id = recipeService.Create(recipeBL, categories, subcategories);
            List<int> data = new List<int> { id, recipe.NrOfIngredients };
            return RedirectToAction("Add", "Ingredients", new IngredientListViewModel
            {
                NrOfIngredients = recipe.NrOfIngredients,
                NrOfInstructions = recipe.NrOfInstructions,
                RecipeID = id
            });
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            var recipeBL = recipeService.GetRecipeByID(id);

            var recipe = new RecipeViewModel()
            {
                RecipeID = recipeBL.RecipeID,
                CookTime = recipeBL.CookTime,
                Description = recipeBL.Description,
                LongDescription = recipeBL.LongDescription,
                Name = recipeBL.Name,
                RatingID = recipeBL.RatingID,
                PictureLocation = recipeBL.PictureLocation,
                PrepTime = recipeBL.PrepTime
            };
            var ingredientsBL = ingredientService.GetAllIngredientsForRecipe(recipe.RecipeID);
            var instructionsBL = instructionsService.GetAllInstructionsForRecipe(recipe.RecipeID);

            var ingredients = new List<IngredientViewModel>();
            var instructions = new List<InstructionViewModel>();

            foreach (var i in ingredientsBL)
            {
                ingredients.Add(new IngredientViewModel()
                {
                    IngredientID = i.IngredientID,
                    Name = i.Name,
                    Quantity = i.Quantity
                });
            }

            foreach (var i in instructionsBL)
            {
                instructions.Add(new InstructionViewModel()
                {
                    InstructionID = i.InstructionID,
                    InstructionText = i.InstructionText
                });
            }
            recipe.ListIngredients = ingredients;
            recipe.ListInstructions = instructions;
            return View(recipe);
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            var recipeBL = recipeService.GetRecipeByID(id);
            var recipe = new RecipeViewModel()
            {
                RecipeID = recipeBL.RecipeID,
                CookTime = recipeBL.CookTime,
                Description = recipeBL.Description,
                LongDescription = recipeBL.LongDescription,
                Name = recipeBL.Name,
                RatingID = recipeBL.RatingID,
                PictureLocation = recipeBL.PictureLocation,
                PrepTime = recipeBL.PrepTime
            };
            var categoriesBL = categoryService.GetAllCategoriesForRecipe(recipe.RecipeID);
            var listOfCategories = new List<CategoryViewModel>();

            var allCategoriesBL = categoryService.GetAllCategories();

            var subcategoriesBL = subcategoryService.GetAllSubCategoriesForRecipe(recipe.RecipeID);
            var listOfSubcategories = new List<SubcategoryViewModel>();

            var allSubcategoriesBL = subcategoryService.GetAllSubcategories();


            foreach (var c in allCategoriesBL)
            {
                if (categoriesBL.Any(prod => prod.Name == c.Name))
                {
                    listOfCategories.Add(new CategoryViewModel
                    {
                        IsSelected = true,
                        CategoryID = c.CategoryID,
                        Name = c.Name
                    });
                }
                else
                {
                    listOfCategories.Add(new CategoryViewModel
                    {
                        IsSelected = false,
                        CategoryID = c.CategoryID,
                        Name = c.Name
                    });
                }
            }



            foreach (var i in listOfCategories)
            {
                recipe.Categories.Add(i);
            }

            foreach (var c in allSubcategoriesBL)
            {
                if (subcategoriesBL.Any(prod => prod.Name == c.Name))
                {
                    listOfSubcategories.Add(new SubcategoryViewModel
                    {
                        SubcategoryID = c.SubcategoryID,
                        Name = c.Name,
                        IsSelected = true

                    });
                }
                else
                {
                    listOfSubcategories.Add(new SubcategoryViewModel
                    {
                        SubcategoryID = c.SubcategoryID,
                        Name = c.Name,
                        IsSelected = false

                    });

                }
            }

            recipe.Categories = listOfCategories;
            recipe.Subcategories = listOfSubcategories;

            return View(recipe);
        }


        [HttpPost]
        public ActionResult Update(RecipeViewModel recipe)
        {
            RecipeBL recipeBL = new RecipeBL
            {
                Description = recipe.Description,
                Name = recipe.Name,
                LongDescription = recipe.LongDescription,
                PictureLocation = recipe.PictureLocation,
                PrepTime = recipe.PrepTime,
                CookTime = recipe.CookTime,
                RecipeID = recipe.RecipeID,
                RatingID = recipe.RatingID
            };

            List<CategoryRecipeBL> categories = new List<CategoryRecipeBL>();
            foreach (var i in recipe.Categories)
            {
                if (i.IsSelected == true)
                {
                    categories.Add(new CategoryRecipeBL
                    {
                        CategoryID = i.CategoryID,
                        RecipeID = recipe.RecipeID

                    });
                }

            }

            List<SubcategoryRecipeBL> subcategories = new List<SubcategoryRecipeBL>();
            foreach (var i in recipe.Subcategories)
            {
                if (i.IsSelected == true)
                {
                    subcategories.Add(new SubcategoryRecipeBL
                    {
                        SubcategoryID = i.SubcategoryID,
                        RecipeID = recipe.RecipeID
                    });
                }
            }
            recipeService.Update(recipeBL, categories, subcategories);
            return RedirectToAction("Update", "Ingredients", new IngredientListViewModel
            {
                RecipeID = recipe.RecipeID
            });
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var recipeBL = recipeService.GetRecipeByID(id);
            var recipe = new RecipeViewModel()
            {
                IsDeleted = false,
                RecipeID = recipeBL.RecipeID,
                Description = recipeBL.Description,
                Name = recipeBL.Name,
                PictureLocation = recipeBL.PictureLocation,
                RatingID = recipeBL.RatingID

            };
            return View(recipe);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRecipe(RecipeViewModel recipe)
        {
            if (recipe.IsDeleted == true)
            {
                ingredientService.DeleteAllIngredientsForRecipe(recipe.RecipeID);
                instructionsService.DeleteAllInstructionsForRecipe(recipe.RecipeID);
                categoryService.DeleteCategoriesForRecipe(recipe.RecipeID);
                subcategoryService.DeleteSubcategoriesForRecipe(recipe.RecipeID);
                recipeService.DeleteRecipeByID(recipe.RecipeID);
                ratingService.Delete(recipe.RatingID);
            }
            return RedirectToAction("Index", "Recipe");
        }

        [HttpGet]
        public ActionResult Filter()
        {
            var allCategories = categoryService.GetAllCategories();
            var allSubcategories = subcategoryService.GetAllSubcategories();
            FilterRecipesViewModel filterRecipesModel = new FilterRecipesViewModel();

            foreach (var c in allCategories)
            {
                filterRecipesModel.Categories.Add(new CategoryViewModel
                {
                    IsSelected = false,
                    CategoryID = c.CategoryID,
                    Name = c.Name

                });
            }

            foreach (var c in allSubcategories)
            {
                filterRecipesModel.Subcategories.Add(new SubcategoryViewModel
                {
                    IsSelected = false,
                    SubcategoryID = c.SubcategoryID,
                    Name = c.Name

                });
            }
            return View(filterRecipesModel);
        }

        [HttpPost]
        public ActionResult Filter(FilterRecipesViewModel filterModel)
        {
            List<int> idSCategories = new List<int>();
            List<int> idSSubcategories = new List<int>();
            List<int> listOfRecipeIDSCat = new List<int>();
            List<int> listOfRecipeIDSSubcat = new List<int>();
            List<int> listIDs = new List<int>();
            List<int> filteredWithoutName = new List<int>();


            foreach (var i in filterModel.Categories)
            {
                if (i.IsSelected == true)
                {
                    idSCategories.Add(i.CategoryID);
                }
            }

            foreach (var i in filterModel.Subcategories)
            {
                if (i.IsSelected == true)
                {
                    idSSubcategories.Add(i.SubcategoryID);
                }
            }
            if (idSCategories.Count() > 0) {
                 listOfRecipeIDSCat = recipeService.GetAllRecipeIDSThatAreInCategories(idSCategories);
            }
            if (idSSubcategories.Count() > 0)
            {
               listOfRecipeIDSSubcat = recipeService.GetAllRecipeIDSThatAreInSubcategories(idSSubcategories);
            }
            


            if (listOfRecipeIDSCat.Count() > 0 && listOfRecipeIDSSubcat.Count() > 0)
            {
                filteredWithoutName.AddRange(listOfRecipeIDSCat.Intersect(listOfRecipeIDSSubcat).ToList());
            }
            else if (listOfRecipeIDSCat.Count() > 0)
            {
                filteredWithoutName.AddRange(listOfRecipeIDSCat);
            }
            else
            {
                filteredWithoutName.AddRange(listOfRecipeIDSSubcat);
            }



            if (filterModel.Name != null && filterModel.Name != "")
            {
                listIDs = recipeService.GetRecipesIDSThatHaveStringInName(filterModel.Name, filteredWithoutName);
                TempData["ids"] = listIDs;
            }
            else
            {
                TempData["ids"] = filteredWithoutName;
            }

            return RedirectToAction("FilterResults", "Recipe");
        }

        [HttpGet]
        public ActionResult FilterResults()
        {
            var ids = new List<int>();
             ids = TempData["ids"] as List<int>;
            List<RecipeViewModel> listOfRecipes = new List<RecipeViewModel>();
            foreach (var i in ids)
            {
                var recipe = recipeService.GetRecipeByID(i);
                listOfRecipes.Add(new RecipeViewModel()
                {
                    RecipeID = recipe.RecipeID,
                    Name = recipe.Name,
                    Description = recipe.Description,
                    PictureLocation = recipe.PictureLocation,
                    CookTime = recipe.CookTime,
                    PrepTime = recipe.PrepTime
                });
            }
            return View(listOfRecipes);
        }

    }
}
