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
    }

}