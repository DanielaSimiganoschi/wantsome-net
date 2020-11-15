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
    public class IngredientService
    {
        private readonly GenericRepository<Ingredients> ingredientRepositoryG;
        private readonly GenericRepository<IngredientsRecipe> ingredientsRecipeRepository;
        private readonly IngredientRepository ingredientRepository;


        public IngredientService()
        {
            ingredientRepositoryG = new GenericRepository<Ingredients>();
            ingredientRepository = new IngredientRepository();
            ingredientsRecipeRepository = new GenericRepository<IngredientsRecipe>();
        }
        public int CreateNewIngredient(string name)
        {
            IngredientRepository i = new IngredientRepository();
            var ingredientDAL = new Ingredients()
            {
                Name = name
            };
           int id = i.Create(ingredientDAL);
            return id;

        }

        public void InsertIngredientForRecipe(int idRecipe, int idIngredient, string quantity)
        {
            var ingredientforRecipeDAL = new IngredientsRecipe()
            {
                RecipeID=idRecipe,
                IngredientID=idIngredient,
                IngredientQuantity=quantity
            };
            ingredientsRecipeRepository.Create(ingredientforRecipeDAL);

        }

        public int CheckIfIngredientExists(string name)
        {

           var allIngredients = ingredientRepositoryG.GetAll();

            var ingredient = allIngredients.Where(x => x.Name == name).FirstOrDefault();

            if (ingredient != null)
            {
                return ingredient.IngredientID;
            }
            else return CreateNewIngredient(name);
        }


        public List<IngredientsRecipeBL> GetAllIngredientsForRecipe(int idRecipe)
        {
            var listIngredients = ingredientRepository.GetAllIngredientsByRecipeID(idRecipe);
            var listIDSints = new List<int>();
            var listOfIngredientsForRecipe = new List<IngredientsRecipeBL>();
            foreach(var i in listIngredients)
            {
                listIDSints.Add(i.IngredientID);
            }

            var listNames = ingredientRepository.GetNamesForRecipeIngredients(listIDSints);

            for(var i = 0; i< listIngredients.Count(); i++)
            {
                for (var j=0;j< listNames.Count(); j++)
                {
                    if(listIngredients[i].IngredientID == listNames[j].IngredientID)
                    {
                        listOfIngredientsForRecipe.Add(new IngredientsRecipeBL()
                        {
                            IngredientID = listIngredients[i].IngredientID,
                            Quantity = listIngredients[i].IngredientQuantity,
                            IngredientsRecipeID = listIngredients[i].IngredientsRecipeID,
                            RecipeID = idRecipe,
                            Name = listNames[i].Name
                        });
                    }
                }
            }
            return listOfIngredientsForRecipe;
         
        }

        public string GetNameForIngredientID(int ingredientID)
        {
            return ingredientRepositoryG.Get(ingredientID).Name;
        }

        public void Update(IngredientsRecipeBL ingredient)
        {
            
            var id = CheckIfIngredientExists(ingredient.Name);
            var ingredientDAL = new IngredientsRecipe()
            {
              IngredientID= id,
              RecipeID = ingredient.RecipeID,
              IngredientQuantity = ingredient.Quantity,
              IngredientsRecipeID = ingredient.IngredientsRecipeID,
              
             
              };

             ingredientsRecipeRepository.Update(ingredientDAL);
        }

        public void DeleteAllIngredientsForRecipe(int id)
        {
            var allIngredients = GetAllIngredientsForRecipe(id);
            foreach(var i in allIngredients)
            {
                ingredientsRecipeRepository.Delete(i.IngredientsRecipeID);
            }
        }

    }
}
