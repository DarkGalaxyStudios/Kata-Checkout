namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;
        private int _numberOfBs;
        private int _numberOfAs;

        public void Scan(string items)
        {
            foreach (var item in items)
            {
                Scan(item);
            }
        }

        private void Scan(char item)
        {
            if (item.Equals('a'))
            {
                Total += 50;
                _numberOfAs++;
                if ((_numberOfAs % 3) == 0)
                {
                    Total -= 20;
                }
            }
            else if (item.Equals('b'))
            {
                Total += 30;
                _numberOfBs++;
                if ((_numberOfBs % 2) == 0)
                {
                    Total -= 15;
                }
            }
        }
    }
}
