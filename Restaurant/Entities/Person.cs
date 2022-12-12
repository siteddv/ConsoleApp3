namespace Restaurant.Entities
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
