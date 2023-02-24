using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastries
  {
    public int CustomerPastriesOrder { get; set; }
    public Pastries(int numberOfPastries)
    {
      CustomerPastriesOrder = numberOfPastries;
    }
  }

}

    // public int PricePerLoaf()
    // {
    //   return (_costPerLoaf);
    // }