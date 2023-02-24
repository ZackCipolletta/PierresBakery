using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class BreadLoaves
  {
    public int CustomerOrder { get; set; }
    
    public BreadLoaves(int numberOfLoaves)
    {
      CustomerOrder = numberOfLoaves;
    }

  }

}