﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saless
{
    class Product
    {
        public string Name;
        public float Price;
        public int SaleAmount;

        public void increaseAmount(int amount)
        {
            if (amount > 0)
            {
                SaleAmount = SaleAmount + amount;
            }
            else
            {
                Console.WriteLine("ERROR : Amount entered is negative");
            }

        }
    }
}
