using Moq;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using Kata.ShoppingCart;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    class CheckoutPriceFinderTests
    {

        [Test]
        public void WillNotProvideSpecialWhenNotOnSale()
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            PriceRules specialRules = new PriceRules(sales);
            Assert.Null(specialRules.PriceCheck("A", 1));
        }

        [Test]
        public void WillNotProvideSpecialPriceWhenNotEnoughQty()
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            sales.Add("A:3", 130);
            PriceRules specialRules = new PriceRules(sales);

            Assert.Null(specialRules.PriceCheck("A", 1));
        }

        [Test]
        [TestCase("A", 3, 130)]
        [TestCase("B", 2, 45)]
        public void WillProvideSpecialPriceWhenEnoughQty(string sku, int qty, int sPrice)
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            sales.Add(String.Format("{0}:{1}", sku, qty), sPrice);

            PriceRules specialRules = new PriceRules(sales);

            Assert.AreEqual(specialRules.PriceCheck(sku, qty), sPrice);
        }
    }
}
