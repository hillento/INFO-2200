using System;
using System.Collections.Generic;
using System.Text;

namespace MyHue.Data
{
  public class HueLight
  {
    
    //Properties of the HueLigt objects
    public string LightId { get; set; }
    public bool On { get; set; }
    public int Brightness { get; set; }
  }
}
