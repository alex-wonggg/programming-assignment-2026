using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//==========================================================
// Student Number : S10272645
// Student Name : Alexander Wong
// Partner Name : Nathan Ho
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
    }
}
