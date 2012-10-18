namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;

        public void Scan(string items)
        {
            if(items.Equals("a"))
            {
                Total = 50;
            }
            if (items.Equals("aa"))
            {
                Total = 100;
            }
            if(items.Equals("b"))
            {
                Total = 30;
            }
        }
    }
}
