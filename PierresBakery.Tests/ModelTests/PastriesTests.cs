using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastries_Pastries()
    {
      Pastries newPastries = new Pastries(3);
      Assert.AreEqual(3, newPastries.CustomerPastriesOrder);
    }

    [TestMethod]
    public void GetPricePerPastry_ReturnsCostPerPastry_Int()
    {
      Pastries newPastries = new Pastries(3);
      Assert.AreEqual(newPastries.PricePerPastry(), 2);
    }

    [TestMethod]
    public void GetTotalCostForPastry_ReturnsTotalCostForNumberOfPastriesOrdered_Int()
    {
      Pastries newPastries = new Pastries(3);
      Assert.AreEqual(6, newPastries.TotalPrice());
    }

        [TestMethod]
    public void GetTotalCostForPastriesOrderSale_ReturnsTotalCostForNumberOfPastriesOrderedWithBuy3Get1FreeSale_Int()
    {
      Pastries newPastries = new Pastries(8);
      Assert.AreEqual(12, newPastries.TotalPrice());
    }

  }
}