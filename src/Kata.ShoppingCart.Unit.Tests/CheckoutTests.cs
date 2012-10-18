using Moq;
using NUnit.Framework;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        private Checkout _checkout;

        [SetUp]
        public void SetUp()
        {
            _checkout = new Checkout();
        }

        [Test]
        public void Initial_total_is_zero()
        {
            Assert.That(_checkout.Total, Is.EqualTo(0));
        }

        [Test]
        public void Scanning_an_empty_item_list_returns_zero()
        {
            _checkout.Scan(string.Empty);

            Assert.That(_checkout.Total, Is.EqualTo(0));
        }   

        [Test]
        public void Scanning_one_a_returns_50()
        {
            _checkout.Scan("a");

            Assert.That(_checkout.Total, Is.EqualTo(50));
        }

        [Test]
        public void Scanning_two_as_returns_100()
        {
            _checkout.Scan("aa");

            Assert.That(_checkout.Total, Is.EqualTo(100));
        }

        [Test]
        public void Scanning_one_b_returns_30()
        {
            _checkout.Scan("b");

            Assert.That(_checkout.Total, Is.EqualTo(30));
        }

        [Test]
        public void Scanning_two_bs_returns_45()
        {
            _checkout.Scan("bb");

            Assert.That(_checkout.Total, Is.EqualTo(45));
        }

        [Test]
        public void Scanning_three_bs_returns_75()
        {
            _checkout.Scan("bbb");

            Assert.That(_checkout.Total, Is.EqualTo(75));
        }
    }
}