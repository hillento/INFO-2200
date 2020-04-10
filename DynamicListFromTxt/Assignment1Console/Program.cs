using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Console
{
  class Program
  {
    
    static void Main(string[] args)
    {
      //Make a new Answers object call answers
      Answers answer = new Answers();
      //Writes a welcome message
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Welcome to Alex's Magic 8 Ball");
      Console.WriteLine("-------------------------------");
      Console.WriteLine();
      Console.WriteLine("Please ask a Question (x to exit): ");
      //Waits for user input
      string userInput = Console.ReadLine();
      //If the user enters anything but x
      while(userInput != "x")
      {
        //Gets a random answer from the GetRandomAnswer method in the answer object and writes it
        Console.WriteLine(answer.GetRandomAnswer());
        //Prompts the user to exit or enter another question
        Console.WriteLine("Please ask another Question (x to exit): ");
        //Waits for user input
        userInput = Console.ReadLine();
      }
      //Exit message
      Console.WriteLine("Thanks for playing!");
      //Prompts an enter key to quit
      Console.WriteLine("Press Enter Key to Close");
      //Reads the next input and quits
      Console.ReadLine();

    }
  }
}
