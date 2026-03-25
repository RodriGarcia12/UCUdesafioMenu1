using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            this.dishes.Remove(dish);
        }

        public Dish GetDishByName(string dishName)
        {
            return this.dishes.FirstOrDefault(d => d.Name == dishName);
        }
    }
}