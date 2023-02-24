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
        public int GetPricePerLoaf()
    {
      return (_costPerLoaf);
    }




  }

}