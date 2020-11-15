using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
   public class InstructionsRepository
    {
        private readonly RecipesDBEntities db;


        public InstructionsRepository()
        {
            db = new RecipesDBEntities();

        }
        public void Create(Instructions instruction)
        {
            db.Instructions.Add(instruction);
            db.SaveChanges();
           
        }

        public List<Instructions> GetAllInstructionsByRecipeID(int id)
        {
            return db.Instructions.Where(i => i.RecipeID == id).ToList();
        }
    }
}
