﻿namespace Restaurant
{
    public class Chief : Person, IDrinkable
    {
        public Chief(string name, List<string> dishes) : base(name)
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