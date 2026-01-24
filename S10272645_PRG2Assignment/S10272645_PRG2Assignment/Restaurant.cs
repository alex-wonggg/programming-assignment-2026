using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//==========================================================
// Student Number : S10272082
// Student Name : Nathan Ho
// Partner Name : Alexander Wong
//==========================================================

namespace S10272645_PRG2Assignment
{
    internal class Restaurant
    {
        private string restaurantId;
        private string restaurantName;
        private string restaurantEmail;

        public string RestaurantId { get { return restaurantId; } set { restaurantId = value; } }
        public string RestaurantName { get { return restaurantName; } set { restaurantName = value; } }
        public string RestaurantEmail { get { return restaurantEmail; } set { restaurantEmail = value; } }
        public List<SpecialOffer> OfferList { get; set; } = new List<SpecialOffer>();
        public List<Menu> MenuList { get; set; } = new List<Menu>();
        public void DisplayOrders()
        {
            /* tbd */
        }
        public void DisplayOffers()
        {
            foreach (SpecialOffer offer in OfferList)
            {
                Console.WriteLine(offer.ToString());
            }
        }
        public void DisplayMenu()
        {
            foreach (Menu menu in MenuList)
            {
                Console.WriteLine(menu.ToString());
            }
        }
        public void AddMenu(Menu menu)
        {
            MenuList.Add(menu);
        }
        public bool RemoveMenu(Menu menu)
        {
            try
            {
                MenuList.Remove(menu);
                return true;
            }
            catch { return false; }
        }
        public string ToString()
        {
            return "joe";
        }
        public Restaurant() { }
        public Restaurant(string i, string n, string e)
        {
            RestaurantId = i;
            RestaurantName = n;
            RestaurantEmail = e;
        }
    }
}
