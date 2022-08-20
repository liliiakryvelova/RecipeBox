using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
    {
        public Recipe()
        {
            this.JoinEntities = new HashSet<RecipeCategory>();
        }

        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string Instruction { get; set; }
        [Range(1,5)]
        public int Rate { get; set; }

        public virtual ICollection<RecipeCategory> JoinEntities { get; set; }
    }
}