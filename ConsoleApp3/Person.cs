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
            Console.WriteLine($"{this.Fullname} bite {person.Fullname}");
        }

        public void Move()
        {
            Console.WriteLine("I\'m moving");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
