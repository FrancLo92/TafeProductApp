using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private double price;
        private int quantity;
        private double totalPayment;
        private double delivery;
        private double wrapping;
        private double gst;
        private double totalChargeAfterDelivery;
        private double totalChargeAfterWrapping;
        private double totalChargeAfterGST;

        private double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private double Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private double Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private double GST
        {
            get { return gst; }
            set { gst = value; }
        }

        public double TotalChargeAfterDelivery
        {
            get { return totalChargeAfterDelivery; }
            set { totalChargeAfterDelivery = value; }
        }

        public double TotalChargeAfterWrapping
        {
            get { return totalChargeAfterWrapping; }
            set { totalChargeAfterWrapping = value; }
        }

        public double TotalChargeAfterGST
        {
            get { return totalChargeAfterGST; }
            set { totalChargeAfterGST = value; }
        }

        //Constructor for Product
        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            Delivery = 25;
            Wrapping = 5;
            GST = 1.1;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;

            TotalChargeAfterDelivery = TotalPayment + Delivery;

            TotalChargeAfterWrapping = TotalPayment + Delivery + Wrapping;

            TotalChargeAfterGST = (TotalPayment + Delivery + Wrapping)* GST;


        }
    }
}
