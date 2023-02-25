using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastries : BakeryItems
  {
    public int CustomerPastriesOrder { get; set; }
    public Pastries(int numberOfPastries)
    {
      CustomerPastriesOrder = numberOfPastries;
      _costPerItem = 2;
    }

    public int PricePerPastry()
    {
      return (_costPerItem);
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