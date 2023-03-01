using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
    [TestClass]
    public class pastry
    {
        [TestMethod]

        public void PriceConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPrice = new Pastry();
            Assert.AreEqual(typeof(Pastry), newPrice.GetType());
        }
        [TestMethod]
        public void PastryPrice_ReturnsPriceOfPastry_int()
        {
            Pastry newPrice = new Pastry();
            int expectedPrice = 2;
            int userQuantity = 1;
            int actualPrice = newPrice.pastryPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }
        [TestMethod]
        public void PastryPrice_ReturnsPriceOfFourPastry_int()
        {
            Pastry newPrice = new Pastry();
            int expectedPrice = 6;
            int userQuantity = 4;
            int actualPrice = newPrice.pastryPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void PastryPrice_ReturnsPriceOfEightPastry_int()
        {
            Pastry newPrice = new Pastry();
            int expectedPrice = 12;
            int userQuantity = 8;
            int actualPrice = newPrice.pastryPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}

