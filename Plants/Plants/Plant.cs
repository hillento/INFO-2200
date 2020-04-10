namespace Plants
{
  //Makes it so you cannot use the plant class on its own. You must used the child classes of plant
  public abstract class Plant
  {
    public Plant(string name, string env, string type)
    {
      //fills the 3 properties with the strings given in the constructor
      Type = type;
      Environment = env;
      Name = name;
    }

    //Properties of the Plant class
    public string Type { get; set; }
    public string Environment { get; set; }
    //Virtual allows this to be overwritten useing override in a child class
    public virtual string Name { get; set; }

    /// <summary>
    /// Returns a string when your call the method Sniff
    /// </summary>
    /// <returns></returns>
    public virtual string Sniff()
    {
      //result of the method
      return "I like the smell of plants";
    }

  }
}
