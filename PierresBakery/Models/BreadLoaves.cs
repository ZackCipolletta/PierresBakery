using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class BreadLoaves
  {
    public int CustomerOrder { get; set; }
    private static int _costPerLoaf; // Since we want both Pastries and BreadLoaves to have this private static field, we could create a new new bakery class that they could inherit this class from instead of creating it for both of them. Also maybe same thing for CsutomerOrder?
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
      if (CustomerOrder % 3 == 0)
      {
        int BreadLoavesOrderCost = PricePerLoaf() * ((CustomerOrder / 3) * 2);
        return BreadLoavesOrderCost;
      }
      else if (CustomerOrder % 3 > 0)
      {
        int BreadLoavesOrderCost = PricePerLoaf() * ((CustomerOrder / 3) * 2) + CustomerOrder % 3 * PricePerLoaf();
        return BreadLoavesOrderCost;
      }
      else
      {
        return PricePerLoaf() * CustomerOrder;
      }
    }

  }

}