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

        [Test]
        public void ShouldFindPriceForItemPassedIn()
        {
            var priceFinder = new Mock<IPriceFinder>();
            var item = "a";
            new Checkout(new Mock<IDiscounter>().Object, priceFinder.Object).Scan(item);
            priceFinder.Verify(v => v.PriceFor(item));
        }
    }
}
