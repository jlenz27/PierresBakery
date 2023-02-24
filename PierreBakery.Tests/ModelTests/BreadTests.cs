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
   

    }
}
