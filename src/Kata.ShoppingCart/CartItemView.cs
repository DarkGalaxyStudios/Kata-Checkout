using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.ShoppingCart
{
    public class CartItemView
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public void ApplySpecial(int minQty, decimal specialPrice)
        {
            if (Qty % minQty == 0)
            {
                this.Price = specialPrice - this.Price;
            }
        }
    }
}
