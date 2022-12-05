namespace Restaurant
{
    public class Waiter : Person, IDrinkable
    {
        public Waiter(string name, Gender gender) : base(name, gender)
        {
        }

        public Guest Guest { get; set; }
        public Chief Chief { get; set; }
        public List<string> Dishes { get; set; }

        public string GetDish()
        {
            if (Chief.IsCooked)
            {
                return Chief.CurrentDish;
            }

            Console.WriteLine($"Waiter {Name} is waiting");
            return null;
        }

        public void TakeGuest(Guest guest)
        {
            Guest = guest;
        }

        public void Drink()
        {
            Console.WriteLine($"Waiter {Name} is drinking");
        }

        public void GiveFoodToGuest()
        {
            foreach(string dish in Dishes)
            {
                Console.WriteLine($"{Name} gave {dish} to {Guest.Name}");
                Guest.GetDish(dish);
            }
        }

        public override string ToString()
        {
            return $"{Name}|{Gender}|{Chief.Name}|{Guest.Name}";
        }
    }
}
