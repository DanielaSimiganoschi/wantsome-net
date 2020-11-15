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
    public class InstructionsController : Controller
    {

        private readonly InstructionsService instructionsService;
        // GET: Instructions

        public InstructionsController()
        {
            instructionsService = new InstructionsService();
        }
      

        [HttpGet]
        public ActionResult Add(InstructionsListViewModel data)
        {
            var instructionListModel = new InstructionsListViewModel()
            {
                RecipeID = data.RecipeID,
                NrOfInstructions = data.NrOfInstructions,
            };
            for (int i = 0; i < instructionListModel.NrOfInstructions; i++)
            {
                instructionListModel.ListOfInstructions.Add(new InstructionViewModel());
            }

            return View(instructionListModel);

        }

      

        [HttpPost]
        [ActionName("Add")]
        public ActionResult AddInstructions(InstructionsListViewModel instructions)
        {
            List<InstructionsBL> instructionsList = new List<InstructionsBL>();

            foreach (var i in instructions.ListOfInstructions)
            {
                instructionsList.Add(new InstructionsBL()
                {
                   InstructionText = i.InstructionText,
                   RecipeID= instructions.RecipeID
                 
                });
            }

            foreach (var i in instructionsList)
            {
                instructionsService.InsertInstructionForRecipe(i);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Update(InstructionsListViewModel instructions)
        {

            var instructionsBL = instructionsService.GetAllInstructionsForRecipe(instructions.RecipeID);


            foreach (var i in instructionsBL)
            {
                instructions.ListOfInstructions.Add(new InstructionViewModel() {
                InstructionID=i.InstructionID,
                InstructionText = i.InstructionText
                });
            }
            instructions.NrOfInstructions = instructionsBL.Count();
            instructions.RecipeID = instructions.RecipeID;
            return View(instructions);

        }

        [HttpPost]
        [ActionName("Update")]
        public ActionResult UpdateInstructions(InstructionsListViewModel instructions)
        {
            List<InstructionsBL> instructionsList = new List<InstructionsBL>();

            foreach (var i in instructions.ListOfInstructions)
            {
                instructionsList.Add(new InstructionsBL()
                {
                  RecipeID = instructions.RecipeID,
                  InstructionID = i.InstructionID,
                  InstructionText = i.InstructionText
                });
            }

 
            foreach (var i in instructionsList)
            {
                instructionsService.Update(i);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
