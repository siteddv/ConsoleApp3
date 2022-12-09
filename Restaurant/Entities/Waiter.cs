namespace Restaurant.Entities
{
    public class Waiter : Person
    {
        public Waiter(string name, Gender gender) : base(name, gender)
        {
        }

        public Guest Guest { get; set; }
        public Chief Chief { get; set; }
        public List<string> Dishes { get; set; }



        public override string ToString()
        {
            return $"{Name}|{Gender}|{Chief.Name}|{Guest.Name}";
        }
    }
}
