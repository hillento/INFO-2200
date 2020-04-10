namespace Plants
{
  public class Tree : Plant
  {
    //Makes a constructor for tree. Inherits the name, env and type from the parent plant (from it's constructor)
    public Tree(string name, string env, string type, string Leaftype) : base(name, env, type)
    {
      //Gets its leaf type from the constructor
      LeafType = Leaftype;
    }
    //Class properties
    //The override property allows me to write the tree name into the plant name since the plant name is virtual
    public override string Name { get; set; }
    public string LeafType { get; set; }
    /// <summary>
    /// Returns a string when your call the method Sniff
    /// </summary>
    /// <returns></returns>
    public override string Sniff()
    {
      //result of the method
      return "Trees really small like Dirt";
    }
  }
}
