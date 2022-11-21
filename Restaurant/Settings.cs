using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public static class Settings
    {
        public static void Init()
        {
            Menu = new List<string>
            {
                OliviePoxyi,
                Plov,
                Manty,
                Pizza,
                Beshbarmak,
                Kuksi,
                Shaurma,
                Morozhenoe
            };
        }

        public static List<string> Menu { get; set; }

        #region Dishes names

        /// <summary>
        /// OliviePoxyi. Cold dish
        /// </summary>
        public static string OliviePoxyi = "OliviePoxyi";

        /// <summary>
        /// Plov. Hot dish
        /// </summary>
        public static string Plov = "Plov";

        /// <summary>
        /// Manty. Hot dish
        /// </summary>
        public static string Manty = "Manty";

        /// <summary>
        /// OliviePoxyi. Pizza dish
        /// </summary>
        public static string Pizza = "Pizza";

        /// <summary>
        /// Beshbarmak. Hot dish
        /// </summary>
        public static string Beshbarmak = "Beshbarmak";

        /// <summary>
        /// Kuksi. Hot dish
        /// </summary>
        public static string Kuksi = "Kuksi";

        /// <summary>
        /// Shaurma. Hot dish
        /// </summary>
        public static string Shaurma = "Shaurma";

        /// <summary>
        /// Morozhenoe. Cold dish
        /// </summary>
        public static string Morozhenoe = "Morozhenoe";

        #endregion
    }
}
