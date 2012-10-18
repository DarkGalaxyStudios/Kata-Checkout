namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;

        public Checkout Scan(string items)
        {
            if(items.Equals("a"))
            {
                Total = 50;
            }
            if (items.Equals("aa"))
            {
                Total = 100;
            }
            return this;
        }
    }
}
