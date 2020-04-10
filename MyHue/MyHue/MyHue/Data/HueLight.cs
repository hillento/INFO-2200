using System;
using System.Collections.Generic;
using System.Text;

namespace MyHue.Data
{
  public class HueLight
  {
    //Class properties
    public string LightId { get; set; }
    public bool On { get; set; }
    public int Brightness { get; set; }
    public int Hue { get; set; }
  }
}
