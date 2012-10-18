using Moq;
using NUnit.Framework;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void Initial_total_is_zero()
        {
            var checkout = new Checkout();

            Assert.That(checkout.Total, Is.EqualTo(0));
        }

        [Test]
        public void Scanning_an_empty_item_list_returns_zero()
        {
            var checkout = new Checkout().Scan(string.Empty);

            Assert.That(checkout.Total, Is.EqualTo(0));
        }
    }
}