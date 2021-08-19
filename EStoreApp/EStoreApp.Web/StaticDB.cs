using System.Collections.Generic;
using EStoreApp.Web.Models.Domain;
using EStoreApp.Web.Models.Enums;

namespace EStoreApp.Web
{
    public class StaticDB
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "MacBook Pro 16\"",
                Reviews = new List<Review>(),
                Description = "Designed for those who defy limits and change the world, the 16-inch MacBook Pro is by far the most powerful " +
                "notebook we have ever made. With an immersive Retina display, superfast processors and advanced graphics it's the ultimate pro notebook" +
                " for the ultimate user.",
                Category = ProductCategory.Laptop,
                Price = 2799
            },

            new Product
            {
                Id = 2,
                Name = "MacBook Air",
                Reviews = new List<Review>(),
                Description = "Our thinnest, lightest notebook, completely transformed by the Apple M1 chip. CPU speeds up to 3.5x faster. " +
                "GPU speeds up to 5x faster. Our most advanced Neural Engine for up to 9x faster machine learning. The longest battery life " +
                "ever in a MacBook Air.",
                Category = ProductCategory.Laptop,
                Price = 1249
            },

            new Product
            {
                Id = 3,
                Name = "iMac 24\"",
                Reviews = new List<Review>(),
                Description = "Say hello to the new iMac. Inspired by the best of Apple. Transformed by the M1 chip. " +
                "Stands out in any space. Fits perfectly into your life.",
                Category = ProductCategory.PC,
                Price = 1499
            },

            new Product
            {
                Id = 4,
                Name = "iMac 27\"",
                Reviews = new List<Review>(),
                Description = "The 27‑inch iMac have superfast processors and graphics, massive memory, and all-flash storage can tackle any workload with ease. " +
                "And with its advanced audio and video capabilities and stunning 5K Retina display, everything you do is larger than life.",
                Category = ProductCategory.PC,
                Price = 2299
            },

            new Product
            {
                Id = 5,
                Name = "iPhone 12",
                Reviews = new List<Review>(),
                Description = "5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display. Ceramic Shield with four times " +
                "better drop performance. And Night mode on every camera. iPhone 12 has it all — in two perfect sizes.",
                Category = ProductCategory.Phone,
                Price = 699
            },

            new Product
            {
                Id = 6,
                Name = "iPhone 12 Pro",
                Reviews = new List<Review>(),
                Description = "5G goes Pro. A14 Bionic rockets past every other smartphone chip. The Pro camera system takes low-light " +
                "photography to the next level — with an even bigger jump on iPhone 12 Pro Max. And Ceramic Shield delivers four times better " +
                "drop performance. Let’s see what this thing can do.",
                Category = ProductCategory.Phone,
                Price = 999
            },

            new Product
            {
                Id = 7,
                Name = "AirPods Pro",
                Reviews = new List<Review>(),
                Description = "Active Noise Cancellation for immersive sound. Transparency mode for hearing what's happening around you. A customizable " +
                "fit for all day. Magic like you've never heard.",
                Category = ProductCategory.Headphones,
                Price = 249
            },

            new Product
            {
                Id = 8,
                Name = "AirPods Max",
                Reviews = new List<Review>(),
                Description = "Introducing AirPods Max — a perfect balance of exhilarating high-fidelity audio and the effortless magic of AirPods. " +
                "The ultimate personal listening experience is here.",
                Category = ProductCategory.Headphones,
                Price = 549
            },
        };
    }
}
