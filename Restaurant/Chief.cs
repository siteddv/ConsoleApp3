namespace Restaurant
{
    public class Chief : Person, IDrinkable
    {
        public Chief(string name, Gender gender, List<string> dishes) : base(name, gender)
        {
            Dishes = dishes;
        }

        private List<string> Dishes { get; set; }
        public string CurrentDish { get; set; }
        public bool IsCooked { get; set; }
        public bool IsCanCook(string dish)
        {
            return Dishes.Contains(dish);
        }
        public void Cook(string dish)
        {
            if (!Dishes.Contains(dish))
            {
                Console.WriteLine("Fuck you");
                return;
            }

            Console.WriteLine($"{dish} is cooking by {Name} cook");
            Console.WriteLine($"{dish} is cooked");
            CurrentDish = dish;
            IsCooked = true;
        }

        public void Drink()
        {
            Console.WriteLine($"Chief {Name} is drinking");
        }

        public override string ToString()
        {
            return $"{Name}|{Gender}|{CurrentDish}";
        }
    }
}
