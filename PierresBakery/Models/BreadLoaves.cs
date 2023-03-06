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

    public int TotalPrice()
    {
      int BreadLoavesOrderCost = _costPerItem * ((CustomerOrder / 3) * 2);
      if (CustomerOrder % 3 == 0)
      {
        return BreadLoavesOrderCost;
      }
      else
      {
        BreadLoavesOrderCost += CustomerOrder % 3 * _costPerItem ;
        return BreadLoavesOrderCost;
      }
    }
  }
}