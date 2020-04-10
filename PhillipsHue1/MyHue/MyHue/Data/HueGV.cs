using System;
using System.Collections.Generic;
using System.Text;

namespace MyHue.Data
{
  public static class HueGV
  {
    //properties of HueGV (Global variables)
    public static string HubIp { get; set; }
    public static string HubUser { get; set; }
    public static List<HueLight> HueLights { get; set; }
    public static HueLight CurrentLight { get; set; }
  }
}
