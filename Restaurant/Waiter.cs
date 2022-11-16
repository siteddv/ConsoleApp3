namespace Restaurant
{
    public class Waiter : Person, IDrinkable
    {
        public Waiter(string name) : base(name)
        {

        }

        public string GetDish(Chief chief)
        {
            if (chief.IsCooked)
            {
                //GiveFood(client);
                //client.Eat()
                return chief.CurrentDish;
            }

            Console.WriteLine($"Waiter {Name} is waiting");
            return null;
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}
