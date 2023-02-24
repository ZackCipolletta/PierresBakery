using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadLoavesConstructor_CreatesInstanceOfBreadLoaves_BreadLoaves()
    {
      BreadLoaves newBreadLoaves = new BreadLoaves(1);
      Assert.AreEqual(newBreadLoaves.CustomerOrder, 1);
    }

    [TestMethod]
    public void SetCostPerLoaf_ReturnsCostPerLoafOfBread_Int()
    {
      BreadLoaves newBreadLoaves = new BreadLoaves(1);
      Assert.AreEqual(newBreadLoaves.GetPricePerLoaf(), 5);
    }





  }
}