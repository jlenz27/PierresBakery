using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
    [TestClass]
    public class Pastery
    {
        [TestMethod]

        public void PriceConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPrice = new Pastry();
            Assert.AreEqual(typeof(Pastry), newPrice.GetType());
        }

            [TestMethod]
        public void breadPrice_ReturnsPriceOfPastry_int()
        {
            Pastry newPrice = new Pastry();
            int expectedPrice = 2;
            int userQuantity = 1;
            int actualPrice = newPrice.PastryPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }

}