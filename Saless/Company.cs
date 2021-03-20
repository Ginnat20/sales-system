using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saless
{
    class Company
    {
        private double LowerPriceProduct;
        private string NameSeller;
        private double AveragePrice;
        private double ProductHigherPrice;
        private string NameSellerHigher;




        public void lowerPriceProduct(Sale firts, Sale second, Sale third, Sale fourth)
        {
            if (firts.priceSale < second.priceSale || firts.priceSale < third.priceSale || firts.priceSale < fourth.priceSale)
            {
                LowerPriceProduct = firts.priceSale;
                NameSeller = firts.seller.Name;
            }
            if (second.priceSale < firts.priceSale || second.priceSale < third.priceSale || second.priceSale < fourth.priceSale)
            {
                LowerPriceProduct = second.priceSale;
                NameSeller = second.seller.Name;
            }
            if (third.priceSale < firts.priceSale || third.priceSale < second.priceSale || third.priceSale < fourth.priceSale)
            {
                LowerPriceProduct = third.priceSale;
                NameSeller = third.seller.Name;
            }
            if (fourth.priceSale < firts.priceSale || fourth.priceSale < second.priceSale || fourth.priceSale < third.priceSale)
            {
                LowerPriceProduct = fourth.priceSale;
                NameSeller = fourth.seller.Name;
            }

        }

        public void calculateAveragePrice(Product firts, Product second, Product third)
        {
            AveragePrice = ((firts.Price + second.Price + third.Price) / 3);

        }

        public void productHigherPrice(Sale firts, Sale second, Sale third, Sale fourth)
        {
            if (firts.priceSale > second.priceSale || firts.priceSale > third.priceSale || firts.priceSale > fourth.priceSale)
            {
                ProductHigherPrice = firts.priceSale;
                NameSellerHigher = firts.product.Name;

            }
            if (second.priceSale > firts.priceSale || second.priceSale > third.priceSale || second.priceSale > fourth.priceSale)
            {
                ProductHigherPrice = second.priceSale;
                NameSellerHigher = second.product.Name;
            }
            if (third.priceSale > firts.priceSale || third.priceSale > second.priceSale || third.priceSale > fourth.priceSale)
            {
                ProductHigherPrice = third.priceSale;
                NameSellerHigher = third.product.Name;
            }
            if (fourth.priceSale > firts.priceSale || fourth.priceSale > second.priceSale || fourth.priceSale > third.priceSale)
            {
                ProductHigherPrice = fourth.priceSale;
                NameSellerHigher = fourth.product.Name;
            }

        }

        public void Print(Product shoes, Product blouse, Product pants)
        {
            Console.WriteLine("Who's the seller (sales man name), who has sold the cheapest product.");
            Console.WriteLine("Answer: {0} and the value was {1}", NameSeller, LowerPriceProduct);
            Console.WriteLine("what is the average price of the products?");
            Console.WriteLine("Answer: {0}", AveragePrice);
            Console.WriteLine("How many unit of the product has been sold.  ");
            Console.WriteLine("Shoes = {0}  Pants = {1}  Blouse = {2}", shoes.SaleAmount, pants.SaleAmount, blouse.SaleAmount);
            Console.Write("What's the most expensive product.");
            Console.WriteLine("the most expensive product is {0} and the value was {1}", NameSellerHigher, ProductHigherPrice);



        }
    }
}
