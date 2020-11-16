using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic.BusinessEntities
{
   public  class RatingsBL
    {
        public int RatingID { get; set; }
        public int NumberOfRatings { get; set; }
        public decimal Score { get; set; }
        public int SumRatings { get; set; }
    }
}
