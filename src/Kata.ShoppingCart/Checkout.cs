namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;

        public Checkout()
        {
            
        }

        public Checkout Scan(string items)
        {
            if(items.Equals("a"))
            {
                Total = 50;
            }
            return this;
        }
    }
}
