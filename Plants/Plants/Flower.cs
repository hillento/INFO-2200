using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
  class Flower : Plant
  {
    public Flower(string name, string env, string type, string petaltype) : base(name, env, type)
    {
      Petaltype = petaltype;
    }
    //Class properties
    //The override property allows me to write the tree name into the plant name since the plant name is virtual
    public override string Name { get; set; }
    public string Petaltype { get; set; }

    /// <summary>
    /// Returns a string when your call the method Sniff
    /// </summary>
    /// <returns></returns>
    public override string Sniff()
    {
      //result of the method
      return "Roses really small like Bad";
    }
  }
}
