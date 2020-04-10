using System;
using System.Collections.Generic;
using System.Text;

namespace MyHue.Data
{
  //Public static class names HueGV with 4 proporties (HUbIP, HubUser, HueLights, CurrentLight)
  public static class HueGV
  {
    //String properties
    public static string HubIp { get; set; }
    public static string HubUser { get; set; }
    //A list of objects from the HueLight Class
    public static List<HueLight> HueLights { get; set; }
    //A Hue light object
    public static HueLight CurrentLight { get; set; }

  }
}
