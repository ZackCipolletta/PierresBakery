using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class BreadLoaves
  {
    public int CustomerOrder { get; set; }
    private static int _costPerLoaf;
    public BreadLoaves(int numberOfLoaves)
    {
      CustomerOrder = numberOfLoaves;
      _costPerLoaf = 5;
    }
    public int PricePerLoaf()
    {
      return (_costPerLoaf);
    }

    public int TotalPrice()
    {
      int BreadLoavesOrderCost = PricePerLoaf() * CustomerOrder;
      return (BreadLoavesOrderCost);
    }


  }

}