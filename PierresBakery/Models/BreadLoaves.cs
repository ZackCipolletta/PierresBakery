namespace PierresBakery.Models
{
  public class BreadLoaves
  {
    public int CustomerOrder { get; set; }
    private static int _costPerItem = 5;
    public BreadLoaves(int numberOfLoaves)
    {
      CustomerOrder = numberOfLoaves;
    }
    public int PricePerLoaf()
    {
      return (_costPerItem);
    }

    public int TotalPrice()
    {
      int BreadLoavesOrderCost = PricePerLoaf() * ((CustomerOrder / 3) * 2);
      if (CustomerOrder % 3 == 0)
      {
        return BreadLoavesOrderCost;
      }
      else
      {
        BreadLoavesOrderCost += CustomerOrder % 3 * PricePerLoaf();
        return BreadLoavesOrderCost;
      }
    }
  }
}