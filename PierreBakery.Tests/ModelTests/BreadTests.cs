using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
    [TestClass]
    public class bread
    {
        [TestMethod]

        public void PriceConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread newPrice = new Bread(5);
            Assert.AreEqual(typeof(Bread), newPrice.GetType());
        }
        [TestMethod]

        public void breadPrice_ReturnsPriceOfBread_int()
        {
            Bread newPrice = new Bread(5);
            int expectedPrice = 5;
            int userQuantity = 1;
            int actualPrice = newPrice.breadPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }

    }
}
