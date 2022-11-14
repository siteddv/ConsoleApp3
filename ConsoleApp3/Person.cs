namespace ConsoleApp3
{
    public class Person : IBitable, IMovable
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname 
        { 
            get => $"{Firstname} {Lastname}"; 
        }

        public virtual void Bite(Person person)
        {
            Console.WriteLine($"Person {Firstname} is biting {person.Firstname}");
        }

        public void Move()
        {
            Console.WriteLine($"Person {Fullname} is moving");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
