using System.ComponentModel.DataAnnotations;
using EStoreApp.Web.Models.Enums;

namespace EStoreApp.Web.Models.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required][MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public ProductCategory Category { get; set; }
        [Required][Range(1,double.MaxValue)]
        public double Price { get; set; }
    }
}
