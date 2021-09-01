using System.Collections.Generic;
using EStoreApp.Domain.Models;

namespace EStoreApp.Services.Services.Interfaces
{
    public interface IProductOrderService
    {
        List<Product> GetProducts();
        List<Order> GetOrders();
        Product GetProductById(int id);
        Order GetOrderById(int id);
        void MakeNewOrder(Order entity);
        void AddNewProduct(Product entity);
    }
}
