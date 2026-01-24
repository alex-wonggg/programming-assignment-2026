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
    internal class Customer
    {
        private string emailAddress;
        private string customerName;
        
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public List<Order> orderlist { get; set; } = new List<Order>();
        public void AddOrder(Order order)
        {
            orderlist.Add(order);
        }
        public bool RemoveOrder(Order order)
        {
            try
            {
                orderlist.Add(order);
                return true;
            }
            catch { return false; }

        }
        public void DisplayAllOrders()
        {
            foreach (Order order in orderlist)
            {
                Console.WriteLine(order.ToString());
            }
        }
        public Customer() { }
        public Customer(string e, string n)
        {
            EmailAddress = e;
            CustomerName = n;
        }
    }
}
