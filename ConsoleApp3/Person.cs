namespace ConsoleApp3
{
    public class Person
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

        public void Bite(Person person)
        {
            Console.WriteLine($"{this.Fullname} bite {person.Fullname}");
        }

        public override string ToString()
        {
            return $"Firstname: {Firstname}\n" +
                $"Lastname: {Lastname}";
        }
    }
}
