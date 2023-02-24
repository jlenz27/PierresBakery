using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
     
 public void PriceConstructor_CreatesInstanceOfPrice_Price()
    {
      Bread newPrice = new Bread(5);
      Assert.AreEqual(typeof(Bread), newPrice.GetType());
    }
        }
    }
}