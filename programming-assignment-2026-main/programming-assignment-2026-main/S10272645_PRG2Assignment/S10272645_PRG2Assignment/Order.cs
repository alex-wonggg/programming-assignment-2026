using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//==========================================================
// Student Number : S10272082
// Student Name : Nathan Ho
// Partner Name : Alexander Wong
//==========================================================

namespace S10272645_PRG2Assignment
{
    internal class Order
    {
        private int orderId;
        private DateTime orderDateTime;
        private double orderTotal;
        private string orderStatus;
        private DateTime deliveryDateTime;
        private string deliveryAddress;
        private string orderPaymentMethod;
        private bool orderPaid;

        public int OrderId { get { return orderId; } set { orderId = value; } }
        public DateTime OrderDateTime { get { return orderDateTime; } set { orderDateTime = value; } }
        public double OrderTotal { get { return orderTotal; } set { OrderTotal = value; } }
        public string OrderStatus { get { return orderStatus; } set { orderStatus = value; } }
        public DateTime DeliveryDateTime { get { return deliveryDateTime; } set { deliveryDateTime = value; } }
        public string DeliveryAddress { get { return deliveryAddress; } set { deliveryAddress = value; } }
        public string OrderPaymentMethod { get { return orderPaymentMethod; } set { orderPaymentMethod = value; } }
        public bool OrderPaid { get { return orderPaid; } set { orderPaid = value; } }
        public List<OrderedFoodItem> Ordereditems { get; set; } = new List<OrderedFoodItem>();

        public double CalculateOrderTotal()
        {
            double total = 0;
            foreach (OrderedFoodItem item in Ordereditems)
            {
                total += item.CalculateSubtotal();
            }
            return total;
        }
        public void AddOrderedFoodItem(OrderedFoodItem fooditem)
        {
            Ordereditems.Add(fooditem);
        }
        public bool RemoveOrderedFoodItem(OrderedFoodItem fooditem)
        {
            try
            {
                Ordereditems.Remove(fooditem);
                return true;
            }
            catch { return false; }
        }
        public void DisplayOrderedFoodItems()
        {
            foreach(OrderedFoodItem fooditem in Ordereditems)
            {
                Console.WriteLine(fooditem.ToString());
            }
        }
        public string ToString()
        {
            return "joe";
        }
        public Order() { }
        public Order(int i, DateTime dt, double t, string s, DateTime ddt, string a, string pm, bool p)
        {
            OrderId = i;
            OrderDateTime = dt;
            OrderTotal = t;
            OrderStatus = s;
            DeliveryAddress = a;
            DeliveryDateTime = ddt;
            OrderPaymentMethod = pm;
            OrderPaid = p;
        }
    }
}