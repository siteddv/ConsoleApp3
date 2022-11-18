namespace Restaurant
{
    public class Guest : Person
    {
        public Guest(string name) : base(name)
        {
        }

        public List<string> Dishes { get; set; }

        public void Eat(string dish)
        {
            if (Settings.Menu.Contains(dish))
            {
                if (Dishes.Contains(dish))
                {
                    Console.WriteLine($"Ammmmm, delicious {dish}");
                    Thread.Sleep(3000);
                    Dishes.Remove(dish);
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
            Dishes.Add(dish);
        }
    }
}
