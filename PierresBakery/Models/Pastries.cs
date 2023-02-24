using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastries
  {
    public int CustomerPastriesOrder { get; set; }
    private static int _costPerPastry;

    public Pastries(int numberOfPastries)
    {
      CustomerPastriesOrder = numberOfPastries;
      _costPerPastry = 2;
    }

    public int PricePerPastry()
    {
      return (_costPerPastry);
    }

    public int TotalPrice()
    {
      if (CustomerPastriesOrder % 4 == 0)
      {
        int PastriesOrderCost = PricePerPastry() * ((CustomerPastriesOrder / 4) * 3);
        return PastriesOrderCost;
      }
      else if (CustomerPastriesOrder % 4 > 0)
      {
        int PastriesOrderCost = PricePerPastry() * ((CustomerPastriesOrder / 4) * 3) + CustomerPastriesOrder % 4 * PricePerPastry();
        return PastriesOrderCost;
      }
      else
      {
        return CustomerPastriesOrder * PricePerPastry();
      }
    }
  }


}