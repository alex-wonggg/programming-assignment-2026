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
    internal class OrderedFoodItem : FoodItem
    {
        private int qtyOrdered;
        private double subTotal;

        public int QtyOrdered { get { return qtyOrdered; } set { qtyOrdered = value; } }
        public double SubTotal { get { return subTotal; } set { subTotal = value; } }
        public double CalculateSubtotal()
        {
            return SubTotal * QtyOrdered;
        }
        public string ToString()
        {
            return "joe";
        }
        public OrderedFoodItem() { }
        public OrderedFoodItem(int q, double s, string n, string d, double p, string c) : base(n, d, p, c)
        {
            QtyOrdered = q;
            SubTotal = s;
        }
    }
}
