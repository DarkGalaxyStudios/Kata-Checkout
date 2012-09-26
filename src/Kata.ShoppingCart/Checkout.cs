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

        public void Scan(string item)
        {
            var discount = _discounter.DiscountFor(item);
            _total -= discount;
        }
    }
}
