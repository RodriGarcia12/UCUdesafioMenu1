using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas, toma la orden y se lo asigna a una mesa.
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

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }

    }
}