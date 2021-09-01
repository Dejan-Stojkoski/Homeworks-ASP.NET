using System.Collections.Generic;
using System.Linq;
using EStoreApp.DataAccess.Repositories;
using EStoreApp.Domain.Models;
using EStoreApp.Services.Services.Interfaces;

namespace EStoreApp.Services.Services
{
    public class ProductOrderService : IProductOrderService
    {
        private IRepository<Product> _productRepository;
        private IRepository<Order> _orderRepository;
        private IRepository<Review> _reviewRepository;
        public ProductOrderService(IRepository<Product> productRepository, IRepository<Order> orderRepository, IRepository<Review> reviewRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _reviewRepository = reviewRepository;
        }

        public void AddNewProduct(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            if(product != null)
            {
                product.Reviews = _reviewRepository.GetAll().Where(x=> x.ProductId == id).ToList();
                return product;
            }

            return null;
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public void MakeNewOrder(Order entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
