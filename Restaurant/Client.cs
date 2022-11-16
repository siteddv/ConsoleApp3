namespace Restaurant
{
    public class Client : Person
    {
        public Client(string name) : base(name)
        {
        }

        public void Eat(string dish)
        {
            if (Settings.Menu.Contains(dish))
            {
                Console.WriteLine($"Ammmmm, delicious {dish}");
            }
            else
            {
                Console.WriteLine("I\'m leaving this fucking restaurant");
            }
        }
    }
}
