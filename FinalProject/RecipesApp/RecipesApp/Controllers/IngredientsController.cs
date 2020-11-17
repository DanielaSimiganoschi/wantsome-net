using RecipesApp.BusinessLogic;
using RecipesApp.BusinessLogic.BusinessEntities;
using RecipesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipesApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IngredientsController : Controller
    {
       
        private readonly IngredientService ingredientService;


        public IngredientsController()
        {
            ingredientService = new IngredientService();
        }
        // GET: Ingredients

        [HttpGet]
        public ActionResult Add(IngredientListViewModel data)
        {
            var ingredientListModel = new IngredientListViewModel()
            {
                RecipeID = data.RecipeID,
                NrOfIngredients = data.NrOfIngredients,
                NrOfInstructions = data.NrOfInstructions
            };
            for (int i = 0; i < ingredientListModel.NrOfIngredients; i++)
            {
                ingredientListModel.ListIngredients.Add(new IngredientViewModel());
            }


            return View(ingredientListModel);

        }




        [HttpPost]
        [ActionName("Add")]
        public ActionResult AddIngredients(IngredientListViewModel ingredients)
        {
            List<IngredientsRecipeBL> ingredientList = new List<IngredientsRecipeBL>();

            foreach (var i in ingredients.ListIngredients)
            {
                ingredientList.Add(new IngredientsRecipeBL()
                {
                    Quantity = i.Quantity,
                    Name = i.Name
                });
            }

            foreach (var i in ingredientList)
            {
                var id = ingredientService.CheckIfIngredientExists(i.Name);
                ingredientService.InsertIngredientForRecipe(ingredients.RecipeID, id, i.Quantity);
            }

            return RedirectToAction("Add", "Instructions", new InstructionsListViewModel
            {
                NrOfInstructions = ingredients.NrOfInstructions,
                RecipeID = ingredients.RecipeID
            });
        }

        [HttpGet]
        public ActionResult Update(IngredientListViewModel ingredientList)
        {
            var ingredientsBL = ingredientService.GetAllIngredientsForRecipe(ingredientList.RecipeID);

            var ingredients = new IngredientListViewModel();

            foreach (var i in ingredientsBL)
            {
                string name = ingredientService.GetNameForIngredientID(i.IngredientID);
                ingredients.ListIngredients.Add(new IngredientViewModel()
                {
                    IngredientID = i.IngredientID,
                    Name = name,
                    Quantity = i.Quantity,
                    IngredientRecipeID = i.IngredientsRecipeID

                });
            }

            ingredients.NrOfIngredients = ingredientsBL.Count();
            ingredients.RecipeID = ingredientList.RecipeID;

            return View(ingredients);

        }

        [HttpPost]
        [ActionName("Update")]
        public ActionResult UpdateIngredients(IngredientListViewModel ingredients)
        {
            List<IngredientsRecipeBL> ingredientList = new List<IngredientsRecipeBL>();

            foreach (var i in ingredients.ListIngredients)
            {
                ingredientList.Add(new IngredientsRecipeBL()
                {
                    Name = i.Name,
                    Quantity = i.Quantity,
                    RecipeID = ingredients.RecipeID,
                    IngredientID = i.IngredientID,
                    IngredientsRecipeID = i.IngredientRecipeID
                });
            }

            foreach (var i in ingredientList)
            {
                ingredientService.Update(i);
            }

            return RedirectToAction("Update", "Instructions", new InstructionsListViewModel
            {
                RecipeID = ingredients.RecipeID
            });
        }

    }
}