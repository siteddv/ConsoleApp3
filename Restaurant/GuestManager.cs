namespace Restaurant
{
    public class GuestManager
    {
        public GuestManager(Guest guest)
        {
            Guest = guest;
        }

        public Guest Guest { get; set; }

        public void Eat(string dish)
        {
            if (Settings.Menu.Contains(dish))
            {
                if (Guest.Orders.Contains(dish))
                {
                    Console.WriteLine($"Ammmmm, delicious {dish} - {Guest.Name} said");
                    Guest.Orders.Remove(dish);
                }
                else
                {
                    Console.WriteLine($"Guest {Guest.Name} eating something else");
                }
            }
            else
            {
                Console.WriteLine("I\'m leaving this fucking restaurant");
            }

        }

        public void TakeWaiter(Waiter waiter)
        {
            Guest.Waiter = waiter;
        }
    }
}
