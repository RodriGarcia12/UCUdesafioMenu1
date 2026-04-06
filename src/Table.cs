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

        public Table(int number)
        {
            this.Number = number;
        }

        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
        }
/*
        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public double Bill()
        {
            double total = 0;
            foreach (Dish dish in this.order)
                total += dish.Price;

            return total;
        }
*/
    }
}