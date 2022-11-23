namespace Restaurant
{
    public class Guest : Person
    {
        public Guest(string name) : base(name)
        {
            Orders = new List<string>();
        }

        public List<string> Orders { get; set; }
        public Waiter Waiter { get; set; }

        public void Eat(string dish)
        {
            if (Settings.Menu.Contains(dish))
            {
                if (Orders.Contains(dish))
                {
                    Console.WriteLine($"Ammmmm, delicious {dish} - {Name} said");
                    Thread.Sleep(3000);
                    Orders.Remove(dish);
                }
                else
                {
                    Console.WriteLine($"Guest {Name} eating something else");
                }
            }
            else
            {
                Console.WriteLine("I\'m leaving this fucking restaurant");
            }
            
        }

        public void GetDish(string dish)
        {
            Orders.Add(dish);
        }

        public void GiveOrder(Waiter waiter, List<string> dishes)
        {
            Waiter = waiter;
            Waiter.TakeGuest(this);
            Waiter.Dishes = dishes;
        }
    }
}
