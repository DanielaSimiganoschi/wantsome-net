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
    public class SubcategoryService
    {
        private readonly GenericRepository<Subcategory> subCategoryRepositoryG;
        private readonly SubcategoryRepository subCategoryRepository;
        private readonly GenericRepository<SubcategoryRecipe> subCategoryRecipeRepositoryG;

        public SubcategoryService()
        {
            subCategoryRepositoryG = new GenericRepository<Subcategory>();
            subCategoryRepository = new SubcategoryRepository();
            subCategoryRecipeRepositoryG = new GenericRepository<SubcategoryRecipe>();
        }
        public List<SubcategoryBL> GetAllSubcategories()
        {
            var listAllSubcategories = subCategoryRepositoryG.GetAll();
            var listAllSubcategoriesBL = new List<SubcategoryBL>();
            foreach (var s in listAllSubcategories)
            {
                listAllSubcategoriesBL.Add(new SubcategoryBL()
                {
                    SubcategoryID = s.SubcategoryID,

                    Name = s.Name
                });
            }
            return listAllSubcategoriesBL;
        }
        public List<SubcategoryBL> GetAllSubCategoriesForRecipe(int idRecipe)
        {
            var listSubCategories = subCategoryRepository.GetAllSubCategoriesByRecipeID(idRecipe);
            var listIDSints = new List<int>();
            var listOfSubCategoriesForRecipe = new List<SubcategoryBL>();
            foreach (var i in listSubCategories)
            {
                listIDSints.Add(i.SubcategoryID);
            }

            var listNames = subCategoryRepository.GetNamesForRecipeSubCategories(listIDSints);

            for (var i = 0; i < listSubCategories.Count(); i++)
            {
                for (var j = 0; j < listNames.Count(); j++)
                {
                    if (listSubCategories[i].SubcategoryID == listNames[j].SubcategoryID)
                    {
                        listOfSubCategoriesForRecipe.Add(new SubcategoryBL()
                        {
                            Name = listNames[j].Name,
                            SubcategoryID = listSubCategories[i].SubcategoryID
                        });
                    }
                }
            }
            return listOfSubCategoriesForRecipe;
        }

        public void DeleteSubcategoriesForRecipe(int id)
        {
            var listSubCategories = subCategoryRepository.GetAllSubCategoriesByRecipeID(id);
            foreach(var s in listSubCategories)
            {
                subCategoryRecipeRepositoryG.Delete(s.SubcategoryRecipeID);
            }
           
        }

    }
}
