namespace Restaurant
{
    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
