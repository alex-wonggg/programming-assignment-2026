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
    internal class FoodItem
    {
        private string itemName;
        private string itemDesc;
        private double itemPrice;
        private string customise;

        public string ItemName { get { return itemName; } set { itemName = value; } }
        public string ItemDesc { get { return itemDesc; } set { itemDesc = value; } }
        public double ItemPrice { get { return itemPrice; } set { itemPrice = value; } }
        public string Customise { get { return customise; } set { customise = value; } }

        public string ToString()
        {
            return "joe";
        }

        public FoodItem() { }
        public FoodItem(string n, string d, double p, string c)
        {
            ItemName = n;
            ItemDesc = d;
            ItemPrice = p;
            Customise = c;
        }
    }
}
