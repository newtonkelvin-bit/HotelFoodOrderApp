using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelFoodOrderApp
{
    public class MenuService
    {
        public List<Order> OrderHistory { get; set; } = new();

        public List<FoodItem> FullMenu { get; set; } = new() {
            new FoodItem { Name = "Chai Special", Price = 70, Category = "Breakfast" },
            new FoodItem { Name = "Coffee Black", Price = 50, Category = "Breakfast" },
            new FoodItem { Name = "Samosa Meat", Price = 30, Category = "Snacks" },
            new FoodItem { Name = "Andazi", Price = 20, Category = "Snacks" },
            new FoodItem { Name = "Sausage", Price = 40, Category = "Snacks" },
            new FoodItem { Name = "Chapati", Price = 25, Category = "Snacks" },
            new FoodItem { Name = "Biriani Beef", Price = 250, Category = "Main Meals" },
            new FoodItem { Name = "Pilau Beef", Price = 170, Category = "Main Meals" },
            new FoodItem { Name = "Fish & Chips", Price = 350, Category = "Main Meals" },
            new FoodItem { Name = "Beef Stew", Price = 180, Category = "Main Meals" },
            new FoodItem { Name = "Chips Regular", Price = 120, Category = "Starches" },
            new FoodItem { Name = "Ugali Portion", Price = 40, Category = "Starches" },
            new FoodItem { Name = "Soda 300ml", Price = 50, Category = "Drinks" },
            new FoodItem { Name = "Passion Juice", Price = 70, Category = "Drinks" }
        };

        public void RecordOrder(List<FoodItem> items, decimal total, string location)
        {
            OrderHistory.Add(new Order
            {
                Id = OrderHistory.Count + 1,
                Items = new List<FoodItem>(items),
                Total = total,
                Location = location,
                OrderTime = DateTime.Now,
                Status = "Pending"
            });
        }

        public class FoodItem
        {
            public string Name { get; set; } = "";
            public decimal Price { get; set; }
            public string Category { get; set; } = "";
            public bool IsAvailable { get; set; } = true;
        }

        public class Order
        {
            public int Id { get; set; }
            public List<FoodItem> Items { get; set; } = new();
            public decimal Total { get; set; }
            public string Location { get; set; } = "";
            public DateTime OrderTime { get; set; }
            public string Status { get; set; } = "Pending";
        }
    }
}