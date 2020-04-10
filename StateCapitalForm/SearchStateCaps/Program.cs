using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStateCaps
{
  class Program
  {
    static void Main(string[] args)
    {
      //Initializing all variables and has a title line with instructions
      List<string> StateCapList = new List<string>();
      Dictionary<String, String> StateCapDict = new Dictionary<string, string>();
      LoadStateCaps(StateCapDict,StateCapList);
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Welcom to Alex's Capital Search App");
      Console.WriteLine("------------------------------------");
      Console.WriteLine();
      Console.Write("Enter a State (x to exit): ");
      string userInput = Console.ReadLine();
      string state = "";
      string capital = "";
      bool found = false;

      while(userInput != "x")
      {
        //foreach (string statecap in StateCapList)
        //{
        //  string[] tempstate = statecap.Split(',');
        //  if(userInput.ToLower() == tempstate[0].ToLower())
        //  {
        //    state = tempstate[0];
        //    state = tempstate[1];
        //    found = true;
        //  }
        //}

        //IF the user input is found in the dictionary
        if(StateCapDict.TryGetValue(userInput,out capital))
        {
          //sets the variable state to the user's input
          state = userInput;
          //Sets the variable found to true
          found = true;
        }
       

        // if found is true...
        if (found)
        {
          //Write the line "The Capital for......"
          Console.WriteLine($"The Capital for {state} is {capital}");
          //Sets found to false so the next input can be read
          found = false;
        }
        //if fouynd is false
        else
        {
          //Writes the message "No Capital found...."
          Console.WriteLine($"No Capital found for {userInput}");
        }
        // Sets up the message prompting the user again
        Console.Write("Enter a State (x to exit): ");
        //Reads the user input
        userInput = Console.ReadLine();
      }
    }
    /// <summary>
    /// Upon loading it finds the file and creates the readers
    /// </summary>
    /// <param name="StateCapDict"></param>
    /// <param name="StateCapList"></param>
    private static void LoadStateCaps(Dictionary<string, string> StateCapDict, List<string> StateCapList)
    {
      //Tries to find the file
      try
      {
        //Create strings that make up the file path
        string filename = "StatesCapitals.txt";
        string filepath;
        string fullfilepath;

        //Finds the curernt user from the system and saves it as a variable
        string Currentuser = Environment.UserName;
        //makes the file path include the currentuser variable
        filepath = $@"C:\users\{Currentuser}\Documents\";
        //Creates the full filepath
        fullfilepath = filepath + filename;
        // sets the input file to the opened file
        StreamReader inputfile = File.OpenText(fullfilepath);
        //while the input file isn't completely read
        while (!inputfile.EndOfStream)
        {
          //Makes a string array from each line making each index based on the comma delimiter
          string[] tempstate = inputfile.ReadLine().Split(',');
          //Adds the array to the dictionary
          StateCapDict.Add(tempstate[0], tempstate[1]);
          //Adds the pair to a list and delimits with a comma
          StateCapList.Add(tempstate[0] + "," + tempstate[1]);
        }
        //closes the file
        inputfile.Close();
      }
      //If the isn't found or cannot be opened report error
      catch (Exception ex)
      {
        //Writes an error to the console
        Console.WriteLine("Could not find file");
        //Waits for input
        Console.ReadLine();
      }
    }
  }
}
