using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantLibrary;

namespace RestoranConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();

            // Добавляем позиции в заказ
            order.AddItem("Pizza", 12.50m);
            order.AddItem("Salad", 5.75m);
            order.AddItem("Soda", 2.50m);

            // Печатаем детали заказа
            order.PrintOrderDetails();

            // Удаляем одну позицию
            order.RemoveItem("Soda");

            // Печатаем детали после удаления
            order.PrintOrderDetails();
        }
    }
}
