namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;

        public void Scan(string items)
        {
            foreach(var item in items)
            {
                Scan(item);
            }
        }

        private void Scan(char item)
        {
            if (item.Equals('a'))
            {
                Total += 50;
            }
            else if (item.Equals('b'))
            {
                Total += 30;
            }
        }
    }
}
