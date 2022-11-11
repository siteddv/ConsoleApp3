namespace ConsoleApp3
{
    public class Player : Person
    {
        public double Height { 
            get 
            { 
                return _height;
            } 
            set 
            {
                _height = value;
            }
        }
        
        private double _height;

        public Player(string firstname, string lastname, int height) 
            : base(firstname, lastname)
        {
            _height = height;
            Console.WriteLine("Player is created");
        }

        //public Player(string name, string surname, double height)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Height = height;
        //}

        //public Player() /*: this("Sergei", "Goldysh", 192)*/
        //{
        //    Console.WriteLine(this);
        //}

        public double Weight
        {
            get
            {
                return _height - 110;
            }
        }

        public string Role
        {
            get
            {
                if(_height > 190)
                {
                    return "Blocker";
                }
                else if(_height > 170)
                {
                    return "Setter";
                }
                else
                {
                    return "Libero";
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n" +
                $"Firstname: {Firstname}\n" +
                $"Lastname: {Lastname}\n" +
                $"Weight: {Weight}\n" +
                $"Height: {Height}";
        }

        public override void Bite(Person person)
        {
            Console.WriteLine("Player is hungry");
        }
    }
}
