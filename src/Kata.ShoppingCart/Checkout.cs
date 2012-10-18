namespace Kata.ShoppingCart
{
    public class Checkout
    {
        public int Total;
        private int _numberOfBs = 0;

        public void Scan(string items)
        {
            foreach(var item in items)
            {
                Scan(item);
            }
            if(_numberOfBs == 2)
            {
                Total -= 15;
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
                _numberOfBs++;
            }
        }
    }
}
