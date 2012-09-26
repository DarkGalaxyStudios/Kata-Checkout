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
            var discounter = new Mock<IDiscounter>();
            Assert.That(0, Is.EqualTo(new Checkout(discounter.Object).Total()));
        }

        [Test]
        public void ScanningShouldGetDiscounts()
        {
            var discounter = new Mock<IDiscounter>();
            new Checkout(discounter.Object).Scan();
            discounter.Verify(v => v.DiscountFor());
        }
    }
}