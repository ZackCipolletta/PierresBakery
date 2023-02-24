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
  }
}