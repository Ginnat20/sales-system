using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saless
{
    class Sale
    {
        public Product product;
        public double priceSale;
        public double TotalPrice;
        public int amount;
        public Seller seller;
        public string Comment;


        public void calculateTotal()
        {
            TotalPrice = priceSale * amount;

        }

    }
}
