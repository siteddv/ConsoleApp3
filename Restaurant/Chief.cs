﻿namespace Restaurant
{
    public class Chief : Person
    {
        public Chief(string name, Gender gender, List<string> dishes) 
            : base(name, gender)
        {
            Dishes = dishes;
        }

        public List<string> Dishes { get; set; }
        public string CurrentDish { get; set; }
        public bool IsCooked { get; set; }
    }
}
