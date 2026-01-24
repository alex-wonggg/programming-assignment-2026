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
    internal class Menu
    {
        private string menuId;
        private string menuName;

        public string MenuId { get { return menuId; } set { menuId = value; } }
        public string MenuName { get { return menuName; } set {menuName = value; } }

        public List<FoodItem> MenuItems { get; set; } = new List<FoodItem>;
        public void AddFoodItem(FoodItem fooditem)
        {
            MenuItems.Add(fooditem);
        }
        public bool RemoveFoodItem(FoodItem fooditem)
        {
            try
            {
                MenuItems.Remove(fooditem);
                return true;
            }
            catch { return false; }
        }
        public void DisplayFoodItems()
        {
            foreach (FoodItem item in MenuItems)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public string ToString()
        {
            return "joe";
        }
        public Menu() { }
        public Menu(string I, string n)
        {
            this.menuId = I;
            this.menuName = n;
        }

    }
}
