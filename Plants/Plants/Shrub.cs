using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
  class Shrub : Plant
  {
    //Makes a constructor for tree. Inherits the name, env and type from the parent plant (from it's constructor)
    public Shrub(string name, string env, string type, string size) : base(name, env, type)
    {

    }
    //Class properties
    //The override property allows me to write the tree name into the plant name since the plant name is virtual
    public override string Name { get; set; }
    public string Size { get; set; }

    /// <summary>
    /// Returns a string when your call the method Sniff
    /// </summary>
    /// <returns></returns>
    public override string Sniff()
    {
      //result of the method
      return "Shrubs really small like Shrubery";
    }
  }
}
