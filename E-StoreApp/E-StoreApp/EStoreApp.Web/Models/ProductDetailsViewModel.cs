using System.Collections.Generic;
using EStoreApp.Domain.Models;

namespace EStoreApp.Web.Models
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Review> Reviews { get; set; }
        public double Rate { get; set; }
        public string Image { get; set; }
    }
}
