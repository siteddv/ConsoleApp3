namespace ConsoleApp3
{
    public class Cicrle
    {
        public Cicrle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double Diametr { 
            get 
            { 
                return Radius * 2;
            } 
        }

        public double Square
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public string Color { get; set; }

        public double Perimetr
        {
            get
            {
                return 6.28 * Radius;
            }
        }
    }
}
