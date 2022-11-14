namespace ConsoleApp3
{
    public class Animal : IMovable, IBitable
    {
        public string Nickname { get; set; }

        public Animal(string name)
        {
            Nickname = name;
        }

        public void Bite(Person person)
        {
            Console.WriteLine($"Animal {Nickname} is biting {person.Firstname}");
        }

        public void Move()
        {
            Console.WriteLine($"Animal {Nickname} is moving");
        }
    }
}
