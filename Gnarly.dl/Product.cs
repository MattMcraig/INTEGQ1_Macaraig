using System;
using System.Collections.Generic;
using System.Text;

namespace Gnarly.dl
{
    public class Product
    {
        public string shirtBrand;
        private string price;
        private DateTime date;

        public Product(string shirtBrand, string price, DateTime date)
        {
            this.shirtBrand = shirtBrand;
            this.price = price;
            this.date = date;


        }


        public string ShirtBrand
        {
            get { return shirtBrand; }
            set { shirtBrand = value; }
        }


        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}