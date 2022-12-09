namespace Restaurant
{
    public class WaiterManager : IDrinkable
    {
        public WaiterManager(Waiter waiter)
        {
            Waiter = waiter;
        }

        public Waiter Waiter { get; set; }
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

        public void GiveFoodToGuest()
        {
            foreach (string dish in Waiter.Dishes)
            {
                Console.WriteLine($"{Waiter.Name} gave {dish} to {Waiter.Guest.Name}");
            }
        }

        public void GetOrder(Guest guest, List<string> dishes)
        {
            Waiter.Guest = guest;
            Waiter.Dishes = dishes;
        }
    }
}
