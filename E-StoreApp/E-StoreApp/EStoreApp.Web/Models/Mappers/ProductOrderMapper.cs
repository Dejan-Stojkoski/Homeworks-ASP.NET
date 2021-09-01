using EStoreApp.Domain.Models;

namespace EStoreApp.Web.Models.Mappers
{
    public static class ProductOrderMapper
    {
        public static ProductsViewModel ProductToProductsViewModel(Product product)
        {
            return new ProductsViewModel
            {
                Id = product.Id,
                Description = product.Description,
                Image = product.Image,
                Name = product.Name,
                Price = product.Price
            };
        }

        public static ProductDetailsViewModel ProductToProductDetailsViewModel(Product product)
        {
            return new ProductDetailsViewModel
            {
                Id = product.Id,
                Description = product.Description,
                Image = product.Image,
                Name = product.Name,
                Price = product.Price,
                Rate = product.Rate,
                Reviews = product.Reviews
            };
        }
    }
}
