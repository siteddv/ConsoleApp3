namespace Restaurant.Entities
{
    public class Guest : Person
    {
        public Guest(string name, Gender gender) : base(name, gender)
        {
            Orders = new List<string>();
        }

        public List<string> Orders { get; set; }



        public override string ToString()
        {
            return $"{Name}|{Gender}|";
        }
    }
}
