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
    public class InstructionsService
    {

        private readonly GenericRepository<Instructions> instructionsRepositoryG;
        private readonly InstructionsRepository instructionsRepository;
       

        public InstructionsService()
        {
            instructionsRepositoryG = new GenericRepository<Instructions>();
            instructionsRepository = new InstructionsRepository();
        }

        public void InsertInstructionForRecipe(InstructionsBL instruction)
        {
            var instructionForRecipeDAL = new Instructions()
            {
                RecipeID = instruction.RecipeID,
                InstructionText = instruction.InstructionText
            };
            instructionsRepositoryG.Create(instructionForRecipeDAL);

        }

        public List<InstructionsBL> GetAllInstructionsForRecipe(int idRecipe)
        {
            var instructions = instructionsRepository.GetAllInstructionsByRecipeID(idRecipe);
            var listOfInstructionsForRecipe = new List<InstructionsBL>();
            foreach (var i in instructions)
            {
                listOfInstructionsForRecipe.Add(new InstructionsBL()
                {
                    InstructionID = i.InstructionID,
                    InstructionText = i.InstructionText
                });
            }
            return listOfInstructionsForRecipe;
        }


        public void Update(InstructionsBL instruction)
        {
            var instructionDAL = new Instructions()
            {
                InstructionID = instruction.InstructionID,
                InstructionText = instruction.InstructionText,
                RecipeID = instruction.RecipeID

            };


            instructionsRepositoryG.Update(instructionDAL);
        }
        public void DeleteAllInstructionsForRecipe(int id)
        {
            var allInstructions = GetAllInstructionsForRecipe(id);
            foreach (var i in allInstructions)
            {
                instructionsRepositoryG.Delete(i.InstructionID);
            }
        }
    }
}
