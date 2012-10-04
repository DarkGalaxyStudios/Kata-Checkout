using Moq;
using NUnit.Framework;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    class CheckoutPriceFinderTests
    {
        [Test]
        public void ShouldRetrieveCorrectPriceForOneItem()
        {
            var priceFinder = new Mock<IPriceFinder>();
            var subject = new Checkout(new Mock<IDiscounter>().Object, priceFinder.Object);
            subject.Scan("A");

            priceFinder.Verify(v => v.PriceFor(It.IsAny<string>()));
        }
    }
}
