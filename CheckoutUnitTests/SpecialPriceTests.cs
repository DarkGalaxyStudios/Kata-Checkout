using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Kata.ShoppingCart;

namespace CheckoutUnitTests
{
    [TestClass]
    public class SpecialPriceTests
    {
        [TestMethod]
        public void WillNotProvideSpecialWhenNotOnSale()
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            PriceRules specialRules = new PriceRules(sales);
            Assert.IsNull(specialRules.PriceCheck("A", 1));
        }

        [TestMethod]
        public void WillNotProvideSpecialPriceWhenNotEnoughQty()
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            sales.Add("A:3", 130);
            PriceRules specialRules = new PriceRules(sales);

            Assert.IsNull(specialRules.PriceCheck("A", 1));
        }

        [TestMethod]
        public void WillProvideSpecialPriceWhenEnoughQty()
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            sales.Add(String.Format("{0}:{1}", "A", 3), 130);
            sales.Add(String.Format("{0}:{1}", "B", 2), 45);

            PriceRules specialRules = new PriceRules(sales);

            Assert.AreEqual(specialRules.PriceCheck("A", 3), 130);
            Assert.AreEqual(specialRules.PriceCheck("B", 2), 45);
        }
    }
}
