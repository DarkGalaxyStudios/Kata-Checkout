using Moq;
using NUnit.Framework;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void EmptyCheckoutHasZeroTotal()
        {
            var mock = new Mock<IDiscounter>();
            Assert.That(0, Is.EqualTo(new Checkout(mock.Object).Total()));
        }
    }
}