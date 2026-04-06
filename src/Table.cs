using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
//        private List<Dish> order = new List<Dish>();
        public int Number { get; set; }
        public bool IsOccupied { get; set; }
        private Order order;

        public Table(int number)
        {
            this.Number = number;
            this.order = new Order(this.Number, false);
        }

        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Free();
        }

        public Order GetOrder(Table table)
        {
            return table.order;
        }

        public void AddToOrder(Dish dish)
        {
            this.order.AddDish(dish);
        }

        public bool HasOrders()
        {
            return this.order.HasDishes();
        }
        public double GetBill()
        {
            return this.order.Bill();
        }

    }
}