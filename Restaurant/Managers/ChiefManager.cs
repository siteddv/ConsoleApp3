using Restaurant.Entities;
using Restaurant.Infrastructure;

namespace Restaurant.Managers
{
    public class ChiefManager : IDrinkable
    {
        public ChiefManager(Chief chief)
        {
            Chief = chief;
        }

        public readonly Chief Chief;
        public bool IsCanCook(string dish)
        {
            return Chief.Dishes.Contains(dish);
        }

        public void Cook(string dish)
        {
            if (!Chief.Dishes.Contains(dish))
            {
                Console.WriteLine("Fuck you");
                return;
            }

            Console.WriteLine($"{dish} is cooking by {Chief.Name} cook");
            Console.WriteLine($"{dish} is cooked");
            Chief.CurrentDish = dish;
            Chief.IsCooked = true;
        }

        public void Drink()
        {
            Console.WriteLine($"Chief {Chief.Name} is drinking");
        }


    }
}
