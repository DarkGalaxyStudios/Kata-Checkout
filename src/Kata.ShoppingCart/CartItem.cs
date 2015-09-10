using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.ShoppingCart
{
    public class CartItem
    {
        #region Properties

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private int _price;
        public int Price { get { return _price; } set { _price = value; } }

        private int _specialQty;
        public int SpecialQty { get { return _specialQty; } set { _specialQty = value; } }

        private int _specialPrice;
        public int SpecialValue { get { return _specialPrice; } set { _specialPrice = value; } }

        #endregion
    }
}
