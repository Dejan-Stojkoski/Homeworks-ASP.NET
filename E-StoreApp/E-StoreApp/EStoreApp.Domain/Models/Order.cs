using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using EStoreApp.Domain.Enums;

namespace EStoreApp.Domain.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool Delivered { get; set; }
        public List<ProductOrder> Products { get; set; } = new List<ProductOrder>();
        public double Price { get { return Products.Sum(x => x.Product.Price); } }
    }
}
