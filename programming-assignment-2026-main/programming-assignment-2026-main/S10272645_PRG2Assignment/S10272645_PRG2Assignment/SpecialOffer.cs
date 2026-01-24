using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    internal class SpecialOffer
    {
        private string offerCode;
        private string offerDesc;
        private double discount;

        public string OfferCode { get { return offerCode; } set { offerCode = value; } }
        public string OfferDesc { get { return offerDesc; } set { offerDesc = value; } }
        public double Discount { get { return discount; } set { discount = value; } }

        public string ToString()
        {
            return "joe";
        }
        public SpecialOffer() { }
        public SpecialOffer(string c, string de, double d)
        {
            OfferCode = c;
            OfferDesc = de;
            Discount = d;
        }
    }
}
