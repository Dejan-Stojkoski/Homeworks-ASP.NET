using System.Collections.Generic;
using EStoreApp.Web.Models.Enums;

namespace EStoreApp.Web.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public List<Review> Reviews { get; set; }
        public double Price { get; set; }
    }
}
