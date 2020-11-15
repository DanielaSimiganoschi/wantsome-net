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
    public class CategoryService
    {
        private readonly GenericRepository<Category> categoryRepositoryG;
        private readonly GenericRepository<CategoryRecipe> categoryRecipeRepositoryG;
        private readonly CategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepositoryG = new GenericRepository<Category>();
            categoryRepository = new CategoryRepository();
            categoryRecipeRepositoryG = new GenericRepository<CategoryRecipe>();
        }

        public List<CategoryBL> GetAllCategories()
        {
            var listAllCategories = categoryRepositoryG.GetAll();
            var listAllCategoriesBL = new List<CategoryBL>();
            foreach (var c in listAllCategories)
            {
                listAllCategoriesBL.Add(new CategoryBL()
                {
                    CategoryID = c.CategoryID,

                    Name = c.Name
                });
            }
            return listAllCategoriesBL;
        }

        public List<CategoryBL> GetAllCategoriesForRecipe(int idRecipe)
        {
            var listCategories = categoryRepository.GetAllCategoriesByRecipeID(idRecipe);
            var listIDSints = new List<int>();
            var listOfCategoriesForRecipe = new List<CategoryBL>();
            foreach (var i in listCategories)
            {
                listIDSints.Add(i.CategoryID);
            }

            var listNames = categoryRepository.GetNamesForRecipeCategories(listIDSints);

            for (var i = 0; i < listCategories.Count(); i++)
            {
                for (var j = 0; j < listNames.Count(); j++)
                {
                    if (listCategories[i].CategoryID == listNames[j].CategoryID)
                    {
                        listOfCategoriesForRecipe.Add(new CategoryBL()
                        {
                            Name = listNames[j].Name,
                            CategoryID = listCategories[i].CategoryID
                        });
                    }
                }
            }
            return listOfCategoriesForRecipe;
        }

        public void DeleteCategoriesForRecipe(int id)
        {
            var listCategories = categoryRepository.GetAllCategoriesByRecipeID(id);
            foreach (var c in listCategories)
            {
                categoryRecipeRepositoryG.Delete(c.CategoryRecipeID);
            }
        }

        
    }
}
