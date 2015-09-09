using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.ShoppingCart
{
    public class Item
    {
        #region Properties
        private string _name;
        public string Name { get { return _name; } set{ _name=value;} }

        private decimal _price;
        public decimal Price { get { return _price; } set { _price = value; } }
        #endregion

        #region Constructor
        public Item(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        #endregion
    }
}
