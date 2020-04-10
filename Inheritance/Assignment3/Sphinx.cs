using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
  //This class is a child of the animal class
  class Sphinx : Animal
  {
    /// <summary>
    /// A constructor that inherits the skintype and food type from the animal class
    /// </summary>
    /// <param name="skintype"></param>
    /// <param name="foodtype"></param>
    public Sphinx(string skintype, string foodtype) : base(skintype, foodtype)
    {
    }

    /// <summary>
    /// Here we have the chance to override the Move class however we just keep it as the base string
    /// </summary>
    /// <returns></returns>
    public override string Move()
    {
      //tells it to return the string found in the base/parent class
      return base.Move();
    }

    /// <summary>
    /// returns the string defined in this class and is required because of the abstract class in Animal
    /// </summary>
    /// <returns></returns>
    public override string Unique()
    {
      //here's the return statement
      return "A riddle is asked";
    }
  }
}
