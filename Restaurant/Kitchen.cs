using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Kitchen
    {
        public List<Chief> Staff { get; set; }

        public Kitchen(List<Chief> staff)
        {
            Staff = staff;
        }

        public void GetOrder(List<string> dishes, Waiter waiter)
        {
            foreach(Chief chief in Staff)
            {
                foreach(string dish in dishes)
                {
                    if (chief.IsCanCook(dish))
                    {
                        chief.Cook(dish);
                        waiter.Chief = chief;
                        continue;
                    }
                }
            }
        }
    }
}
