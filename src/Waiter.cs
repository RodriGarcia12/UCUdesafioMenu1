using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();

        public string Name { get; set; }

        public Waiter(string name)
        {
            this.Name = name;
        }

        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }

        public void TakeOrder(Order order, Dish dish)
        {
            order.AddToOrder(dish);
        }

    }
}