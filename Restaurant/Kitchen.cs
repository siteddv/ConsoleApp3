namespace Restaurant
{
    public class Kitchen
    {
        public List<ChiefManager> Staff { get; set; }

        public Kitchen(List<ChiefManager> staff)
        {
            Staff = staff;
        }

        public void GetOrder(Waiter waiter)
        {
            foreach(string dish in waiter.Dishes)
            {
                foreach (ChiefManager chief in Staff)
                {
                    if (chief.IsCanCook(dish))
                    {
                        chief.Cook(dish);
                        waiter.Chief = chief.Chief;
                        break;
                    }
                }
            }
        }
    }
}
