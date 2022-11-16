namespace Restaurant
{
    public class Chief : Person, IDrinkable
    {
        public Chief(string name, string[] dishes) : base(name)
        {
            Dishes = dishes;
        }

        public string[] Dishes { get; set; }
        public string CurrentDish { get; set; }
        public bool IsCooked { get; set; }
        public void Cook(string dish)
        {
            if (!Dishes.Contains(dish))
            {
                Console.WriteLine("Fuck you");
                return;
            }

            Console.WriteLine($"{dish} is cooking by {Name} cook");
            Thread.Sleep(1000);
            Console.WriteLine($"{dish} is cooked");
            CurrentDish = dish;
            IsCooked = true;
        }

        public void Drink()
        {
            Console.WriteLine($"Chief {Name} is drinking");
        }
    }
}
