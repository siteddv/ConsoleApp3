using Restaurant.Entities;
using Restaurant.Infrastructure;

namespace Restaurant.Managers
{
    public class GuestManager
    {
        public GuestManager(Guest guest)
        {
            Guest = guest;
        }

        public readonly Guest Guest;

        public void Eat()
        {
            foreach (string dish in Guest.Orders)
            {
                EatDish(dish);
            }
        }

        public void GetCookedDishes(List<string> dishes)
        {
            Guest.Orders.AddRange(dishes);
        }

        private void EatDish(string dish)
        {
            if (Settings.Menu.Contains(dish))
            {
                Console.WriteLine($"Ammmmm, delicious {dish} - {Guest.Name} said");
                Guest.Orders.Remove(dish);
            }
            else
            {
                Console.WriteLine($"{Guest.Name} guest is eating something else");
            }
        }
    }
}
