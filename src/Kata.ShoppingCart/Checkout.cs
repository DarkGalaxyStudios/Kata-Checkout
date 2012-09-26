using System.Globalization;

namespace Kata.ShoppingCart
{
    public class Checkout
    {
        private readonly IDiscounter _discounter;
        private int _total;

        public Checkout(IDiscounter discounter)
        {
            _discounter = discounter;
            _total = 0;
        }

        public int Total()
        {
            return _total;
        }

        public void Scan(string items)
        {
            foreach (var item in items.ToCharArray())
            {
                var discount = _discounter.DiscountFor(item.ToString(CultureInfo.InvariantCulture));
                _total -= discount;
            }
        }
    }
}
