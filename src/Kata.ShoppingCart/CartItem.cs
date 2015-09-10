using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.ShoppingCart
{
    public class CartItem
    {
        #region Properties

        public string SKU { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        #endregion

        public CartItem()
        {

        }
    }

    public class CartItemViewModel
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
