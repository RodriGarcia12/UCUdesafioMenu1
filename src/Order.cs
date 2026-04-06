using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> order = new List<Dish>();
        public double Total;
        public bool Delivery;
        public int Table;

        public Order(int table, bool delivery)
        {
            this.Table = table;
            this.Delivery = delivery;
            this.Total = 0;
        }
        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public void Free()
        {
            this.order.Clear();
        }

        public double Bill()
        {
            foreach (Dish dish in this.order)
                this.Total += dish.Price;

            return this.Total;
        }

    }
}