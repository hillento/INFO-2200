using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
  //Makes the class abstract so you can add child classes that inherit the properties of the class
  public abstract class Animal
  {
    //Constructor method accepts two string inputs
    public Animal(string skinType, string foodType)
    {
      //Assigns the public attributes from the constructor method
      SkinType = skinType;
      FoodType = foodType;
    }
    //class properties
    public string SkinType { get; set; }
    public string FoodType { get; set; }

    //Concrete methods eat and reproduce return strings if called
    public string Eat()
    {
      return "Chomp Chomp";
    }

    public string Reproduce()
    {
      return "Another abomination has been created";
    }

    //Virtual method, is easily redefinable but will just return this string
    public virtual string Move()
    {
      return "Run away! It's moving!";
    }

    //This unique method is abstract and will be in every class but will be uniquely defined in all child classes
    public abstract string Unique();
  }
  


}
