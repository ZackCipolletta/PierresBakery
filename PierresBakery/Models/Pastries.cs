namespace PierresBakery.Models
{
  public class Pastries
  {
    public int CustomerPastriesOrder { get; set; }
    private static int _costPerItem = 2;
    public Pastries(int numberOfPastries)
    {
      CustomerPastriesOrder = numberOfPastries;
    }

    public int TotalPrice()
    {
      int PastriesOrderCost = _costPerItem * ((CustomerPastriesOrder / 4) * 3);
      if (CustomerPastriesOrder % 4 == 0)
      {
        return PastriesOrderCost;
      }
      else
      {
        PastriesOrderCost += CustomerPastriesOrder % 4 * _costPerItem;
        return PastriesOrderCost;
      }
    }
  }
}