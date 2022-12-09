namespace Restaurant
{
    public class ChiefManager : IDrinkable
    {
        public ChiefManager(Chief chief)
        {
            Chief = chief;
        }

        public Chief Chief { get; set; }
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

        public override string ToString()
        {
            return $"{Chief.Name}|{Chief.Gender}|{Chief.CurrentDish}";
        }
    }
}
