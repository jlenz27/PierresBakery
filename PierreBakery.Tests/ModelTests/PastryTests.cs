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
    }

}