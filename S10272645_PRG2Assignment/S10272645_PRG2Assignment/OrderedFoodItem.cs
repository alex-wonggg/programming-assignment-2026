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
    internal class OrderedFoodItem
    {
        private int qtyOrdered;
        private double subTotal;

        public int QtyOrdered { get { return qtyOrdered; } set { qtyOrdered = value; } }
        public double SubTotal { get { return subTotal; } set { subTotal = value; } }
    }
}
