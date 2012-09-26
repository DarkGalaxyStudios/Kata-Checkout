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
            new Checkout(discounter.Object).Scan("");
            discounter.Verify(v => v.DiscountFor(It.IsAny<string>()));
        }

        [Test]
        public void ScanningShouldGetDiscountForScannedItem()
        {
            var discounter = new Mock<IDiscounter>();
            new Checkout(discounter.Object).Scan("a");
            discounter.Verify(v => v.DiscountFor("a"));
        }

        [Test]
        public void GettingTotalWithDiscountAppliesDiscount()
        {
            var discounter = new Mock<IDiscounter>();
            discounter.Setup(v => v.DiscountFor(It.IsAny<string>())).Returns(20);
            var checkout = new Checkout(discounter.Object);
            checkout.Scan("a");
            Assert.That(checkout.Total(), Is.EqualTo(-20));
        }
    }
}