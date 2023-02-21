using System.Collections.Generic;

namespace CoinCounter.Models
{
  public class Amount
  {
     private int _value;
    
    //private int _remainderValue;
     public int Value
     {
        get { return _value; }
     }
    
    public Amount(int amount)
    {
        _value = amount;
    }

    public int NumberToQuarterToDivide(int _value)
    {
      int remainderValue = _value % 25; // Quarter
      return remainderValue;
    }

 public int NumberToDimeToDivide(int _value)
    {
      int remainderValue = _value % 10; // dime
      return remainderValue;
    }

  public int NumberToNickelToDivide(int _value)
    {
      int remainderValue = _value % 5; // Nickel
      return remainderValue ;
    }





      // public static void ClearAll()
      //   {
      //       _instances.Clear();
      //   }

  }
}