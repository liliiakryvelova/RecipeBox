using System.Collections.Generic;

namespace RecipeBox.Models
{
    public class Category
    {
        public Category()
        {
            this.JoinEntities = new HashSet<RecipeCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<RecipeCategory> JoinEntities { get; set; }
    }
}