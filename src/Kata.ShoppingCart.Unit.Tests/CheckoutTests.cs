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
            Assert.That(new Checkout().Total, Is.EqualTo(0));
        }

        [Test]
        public void Scanning_an_empty_item_list_returns_zero()
        {
            Assert.That(new Checkout().Scan(string.Empty).Total, Is.EqualTo(0));
        }
    }
}