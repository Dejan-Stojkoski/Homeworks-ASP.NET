using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using EStoreApp.Domain.Enums;

namespace EStoreApp.Domain.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public double Rate { get { return Reviews.Count == 0 ? 0 : Reviews.Sum(x => x.Rate) / Reviews.Count; } }
        public List<ProductOrder> Orders { get; set; }
        public string Image { get; set; }
    }
}
