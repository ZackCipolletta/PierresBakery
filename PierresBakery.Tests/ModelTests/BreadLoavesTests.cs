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

      int result = newBreadLoaves.TotalPrice();

      Assert.AreEqual(result, 5);
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
      BreadLoaves newBreadLoaves = new BreadLoaves(7);
      Assert.AreEqual(25, newBreadLoaves.TotalPrice());
    }

  }
}