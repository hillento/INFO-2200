using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1Console
{
  public class Answers
  {
    List<string> MagicAnswersList;
    Random rand;
    public Answers()
    {
      MagicAnswersList = new List<string>();
      rand = new Random();
      LoadAnswers();
    }

    private void LoadAnswers()
    {
      //Tries to find file of answers
      try
      {
        //Creates the File name and path
        const string FILE_PATH = @"C:\Users\Alex\Desktop\INFO2200\";
        const string FILE_NAME = "8ball.txt";
        string FullFilePath = FILE_PATH + FILE_NAME;

        //Creates a stream reader to read the file
        StreamReader inputfile = File.OpenText(FullFilePath);
        //While the file path isn't completely read
        while (!inputfile.EndOfStream)
        {
          //Add the answers to the Magic AnswerList
          MagicAnswersList.Add(inputfile.ReadLine());
        }
        //Closes the file
        inputfile.Close();


      }
      catch (Exception ex)
      {
        //Prints error message if file isn't found
        Console.WriteLine("Could not Find File");
        //Waits for input
        Console.ReadLine();
      }

    }
    /// <summary>
    /// Gets a random answer from the answers list
    /// </summary>
    /// <returns></returns>
    public string GetRandomAnswer()
    {
      //Generates a random number from 0 to 1- the number of items in the list
      int randnum = rand.Next(MagicAnswersList.Count);
      //Returns the list index that corresponds to that random number
      return MagicAnswersList[randnum];
    }
  }
  
}
