namespace Kata.ShoppingCart
{
    public class Checkout
    {
        private readonly IDiscounter _discounter;

        public Checkout(IDiscounter discounter)
        {
            _discounter = discounter;
        }

        public int Total()
        {
            return 0;
        }

        public void Scan()
        {
                _discounter.DiscountFor();
        }
    }
}
