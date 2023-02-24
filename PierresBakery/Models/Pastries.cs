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

  }

}

    // public int PricePerLoaf()
    // {
    //   return (_costPerLoaf);
    // }