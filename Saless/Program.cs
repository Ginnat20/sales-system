using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saless
{
    class Program
    {
        static void Main(string[] args)
        {
            Product shoes = new Product();
            shoes.Name = "Shoes";
            shoes.Price = 500;

            Product pants = new Product();
            pants.Name = "Pants";
            pants.Price = 300;

            Product blouse = new Product();
            blouse.Name = " Blouse";
            blouse.Price = 150;

            Seller juan = new Seller();
            juan.Name = "Juan";
            juan.Age = 24;


            Seller yulieth = new Seller();
            yulieth.Name = "Yulieth";
            yulieth.Age = 19;


            Seller santiago = new Seller();
            santiago.Name = "Santiago";
            santiago.Age = 19;



            Sale initSale = new Sale();
            initSale.product = pants;
            initSale.seller = juan;
            initSale.priceSale = pants.Price;
            initSale.amount = 5;
            initSale.calculateTotal();
            pants.increaseAmount(initSale.amount);

            Sale secondSale = new Sale();
            secondSale.product = pants;
            secondSale.seller = yulieth;
            secondSale.priceSale = pants.Price;
            secondSale.amount = 50;
            secondSale.calculateTotal();
            pants.increaseAmount(secondSale.amount);


            Sale thirdSale = new Sale();
            thirdSale.product = blouse;
            thirdSale.seller = santiago;
            thirdSale.priceSale = blouse.Price;
            thirdSale.amount = 5;
            blouse.SaleAmount = thirdSale.amount;
            thirdSale.calculateTotal();


            Sale fourthSale = new Sale();
            fourthSale.product = shoes;
            fourthSale.seller = yulieth;
            fourthSale.priceSale = shoes.Price;
            fourthSale.amount = 5;
            shoes.SaleAmount = fourthSale.amount;
            fourthSale.calculateTotal();

            Company result = new Company();
            result.lowerPriceProduct(initSale, secondSale, thirdSale, fourthSale);
            result.productHigherPrice(initSale, secondSale, thirdSale, fourthSale);
            result.calculateAveragePrice(shoes, blouse, pants);
            result.Print(shoes, blouse, pants);

        }
    }
    
}
