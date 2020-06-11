using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edura.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
