using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
    }
  }
}