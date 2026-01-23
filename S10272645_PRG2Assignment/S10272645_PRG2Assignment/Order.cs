using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//==========================================================
// Student Number : S10272645
// Student Name : Alexander Wong
// Partner Name : Nathan Ho
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
        private bool orederPaid;

        public int OrderId { get { return orderId; } set { orderId = value; } }
        public DateTime OrderDateTime { get { return orderDateTime; } set { orderDateTime = value; } }
        public double OrderTotal { get { return orderTotal; } set { OrderTotal = value; } }
        public string OrderStatus { get { return orderStatus; } set { orderStatus = value; } }
        public DateTime DeliveryDateTime { get { return deliveryDateTime; } set { deliveryDateTime = value; } }
        public string DeliveryAddress { get { return deliveryAddress; } set { deliveryAddress = value; } }
        public string OrderPaymentMethod { get { return orderPaymentMethod; } set { orderPaymentMethod = value; } }
        public bool OrederPaid { get { return orederPaid; } set { orederPaid = value; } }


    }
}