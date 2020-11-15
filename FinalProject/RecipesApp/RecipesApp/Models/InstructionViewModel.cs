using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class InstructionViewModel
    {
        public int InstructionID { get; set; }
        [Required]
        public string InstructionText { get; set; }
    }
}