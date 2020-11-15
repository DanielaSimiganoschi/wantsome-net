using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class RatingViewModel
    {
        public int RatingID { get; set; }
        public int NumberOfRatings { get; set; }
        public decimal Score { get; set; }
        public int SumRatings { get; set; }
    }
}