using System.Collections.Generic;

namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;
        private readonly Dictionary<char, int> _price = new Dictionary<char, int>
        {
            {'a', 50},
            {'b', 30}
        };
        private readonly Dictionary<char, int> _discountAmount = new Dictionary<char, int>
        {
            {'a', 20},
            {'b', 15}
        };
        private readonly Dictionary<char, int> _discountQuantity = new Dictionary<char, int>
        {
            {'a', 3},
            {'b', 2}
        };
        private readonly Dictionary<char, int> _itemCount = new Dictionary<char, int>
        {
            {'a', 0},
            {'b', 0}
        };

        public void Scan(string items)
        {
            foreach (var item in items)
            {
                Scan(item);
            }
        }

        private void Scan(char item)
        {
            Total += _price[item];

            if ((++_itemCount[item] % _discountQuantity[item]) == 0)
            {
                Total -= _discountAmount[item];
            }
        }
    }
}
