using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvc.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}