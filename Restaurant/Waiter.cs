namespace Restaurant
{
    public class Waiter : Person, IDrinkable
    {
        public Waiter(string name) : base(name)
        {

        }

        public Guest Guest { get; set; }

        public string GetDish(Chief chief)
        {
            if (chief.IsCooked)
            {
                //GiveFood(guest);
                //guest.Eat()
                return chief.CurrentDish;
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
            throw new NotImplementedException();
        }
        public void GiveFood(string dish)
        {
            Console.WriteLine($"{Name} gave {dish} to {Guest.Name}");
            Guest.GetDish(dish);
        }
    }
}
