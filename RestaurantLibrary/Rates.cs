using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantLibrary
{
    public class OrderItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public OrderItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Order
    {
        private List<OrderItem> _items;

        public Order()
        {
            _items = new List<OrderItem>();
        }

        // Добавить блюдо в заказ
        public void AddItem(string itemName, decimal itemPrice)
        {
            _items.Add(new OrderItem(itemName, itemPrice));
        }

        // Удалить блюдо из заказа
        public void RemoveItem(string itemName)
        {
            _items.RemoveAll(item => item.Name == itemName);
        }

        // Рассчитать общую сумму заказа
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Price;
            }
            return total;
        }

        // Показать детали заказа
        public void PrintOrderDetails()
        {
            Console.WriteLine("Order details:");
            foreach (var item in _items)
            {
                Console.WriteLine($"{item.Name}: {item.Price:C}");
            }
            Console.WriteLine($"Total: {GetTotalPrice():C}");
        }
    }
}