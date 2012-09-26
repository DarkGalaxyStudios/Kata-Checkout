using NUnit.Framework;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void EmptyCheckoutHasZeroTotal()
        {
            Assert.That(0, Is.EqualTo(new Checkout().Total()));
        }
    }
}