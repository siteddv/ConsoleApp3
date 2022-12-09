using Restaurant.Entities;
using Restaurant.Infrastructure;

namespace Restaurant.Managers
{
    public class WaiterManager : IDrinkable
    {
        public WaiterManager(Waiter waiter)
        {
            Waiter = waiter;
        }

        public readonly Waiter Waiter;
        public string GetDish()
        {
            if (Waiter.Chief.IsCooked)
            {
                return Waiter.Chief.CurrentDish;
            }

            Console.WriteLine($"Waiter {Waiter.Name} is waiting");
            return null;
        }

        public void Drink()
        {
            Console.WriteLine($"Waiter {Waiter.Name} is drinking");
        }

        public List<string> GetCookedDishes()
        {
            foreach (string dish in Waiter.Dishes)
            {
                Console.WriteLine($"{Waiter.Name} gave {dish} to {Waiter.Guest.Name}");
            }

            return Waiter.Dishes;
        }

        public void GetOrder(Guest guest, List<string> dishes)
        {
            Waiter.Guest = guest;
            Waiter.Dishes = dishes;
        }
    }
}
