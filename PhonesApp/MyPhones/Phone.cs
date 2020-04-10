using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhones
{
  public class Phone
  {

    public Phone(string[] deets)
    {
      //how to assign the indexes of the input array
      Brand = deets[0];
      Model = deets[1];
      Price = decimal.Parse(deets[2]);
      Details = deets[3];
    }
    /// <summary>
    /// Class variables
    /// </summary>
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public string Details { get; set; }

  }
}
