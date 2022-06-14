using NUnit.Framework;
using ShoppingCartKata;
using System.Collections.Generic;

namespace ShoppingCartKataTests
{
    public class CheckoutTests
    {
        [Test]
        public void NoItemsIsZero()
        {
            var sut = new Checkout(new List<PriceRule>());

            Assert.AreEqual(0, sut.Total);
        }

        [Test]
        public void Scan1Item_A_TotalIs50()
        {
            var rules = new List<PriceRule> { new PriceRule("A", 50) };

            var sut = new Checkout(rules);

            sut.Scan("A");
            
            Assert.AreEqual(50, sut.Total);
        }

        [Test]
        public void Scan2SimilarItems_AA_TotalIs100()
        {
            var rules = new List<PriceRule> { new PriceRule("A", 50) };

            var sut = new Checkout(rules);

            sut.Scan("A");
            sut.Scan("A");

            Assert.AreEqual(100, sut.Total);
        }

        [Test]
        public void Scan2DifferentItems_AB_TotalIs80()
        {
            var rules = new List<PriceRule> { new PriceRule("A", 50), new PriceRule("B", 30) };

            var sut = new Checkout(rules);

            sut.Scan("A");
            sut.Scan("B");

            Assert.AreEqual(80, sut.Total);
        }
    }
}