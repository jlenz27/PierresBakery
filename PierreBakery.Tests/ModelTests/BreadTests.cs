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
            Bread newPrice = new Bread();
            Assert.AreEqual(typeof(Bread), newPrice.GetType());
        }

        [TestMethod]
        public void breadPrice_ReturnsPriceOfBread_int()
        {
            Bread newPrice = new Bread();
            int expectedPrice = 5;
            int userQuantity = 1;
            int actualPrice = newPrice.breadPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void breadPrice_ReturnPriceFor3Loafs_int()
        {
            Bread newPrice = new Bread();
            int expectedPrice = 10;
            int userQuantity = 3;
            int actualPrice = newPrice.breadPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void breadPrice_ReturnPriceFor6Loafs_int()
        {
            Bread newPrice = new Bread();
            int expectedPrice = 20;
            int userQuantity = 6;
            int actualPrice = newPrice.breadPrice(userQuantity);
            Assert.AreEqual(expectedPrice, actualPrice);
        }


    }
}
