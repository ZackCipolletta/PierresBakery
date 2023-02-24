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
    public void GetPricePerLoaf_ReturnsCostPerLoafOfBread_Int()
    {
      BreadLoaves newBreadLoaves = new BreadLoaves(1);
      Assert.AreEqual(newBreadLoaves.PricePerLoaf(), 5);
    }

    [TestMethod]
    public void GetTotalCostForBreadOrder_ReturnsTotalCostForNumberOfLoavesOrdered_Int()
    {
      BreadLoaves newBreadLoaves = new BreadLoaves(2);
      Assert.AreEqual(10, newBreadLoaves.TotalPrice());
    }

    [TestMethod]
    public void GetTotalCostForBreadOrderSale_ReturnsTotalCostForNumberOfLoavesOrderedWithBuy2Get1FreeSale_Int()
    {
      BreadLoaves newBreadLoaves = new BreadLoaves(5);
      Assert.AreEqual(20, newBreadLoaves.TotalPrice());
    }



  }
}