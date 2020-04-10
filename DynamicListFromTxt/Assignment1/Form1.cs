using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment1
{
  public partial class Form1 : Form
  {
    //Vaiables
    const string FILE_PATH = @"C:\Users\Alex\Desktop\INFO2200\";
    const string FILE_NAME = "8ball.txt";
    string FullFilePath;

    public Form1()
    {
      InitializeComponent();
      FullFilePath = FILE_PATH + FILE_NAME;
    }

    /// <summary>
    /// Take the text (if there is any) from the text box and save it to the text file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void BtnSubmitResponse_Click(object sender, EventArgs e)
    {
      //Tests text box to ensure it isn't blank
      if(TxtAnswer.Text != "")
      {
        // Make a string variable from the text box
        string answer = $"{TxtAnswer.Text}";
        //Add the answer to the answer list
        ListBoxAnswers.Items.Add(answer);
        //Sort the list box for fun
        ListBoxAnswers.Sorted = true;
        //Save the file
        SaveAnswersList(answer);
        //Confirm Submission
        MessageBox.Show($"Thank you for entering {TxtAnswer.Text}");
        //Clearsthe text box
        TxtAnswer.Clear();
        //Focuses on the text box
        TxtAnswer.Focus();
      }
    }
    /// <summary>
    /// A method to write the users input to the text file, then save and close it
    /// </summary>
    /// <param name="answer"></param>
    private void SaveAnswersList(string answer)
    {
      //Tries to find the file we're writing too
      try
      {
        //Create a streamwriter called ouput that appends the text box to the file
        StreamWriter outputfile = File.AppendText(FullFilePath);
        outputfile.WriteLine(answer);
        //Close the file
        outputfile.Close();
      }
      catch(Exception ex)
      {
        //If your cannot find the file populate error
        MessageBox.Show(ex.Message);
      }
    }

    /// <summary>
    /// Loads the form with the saved answers from the text file and add them to the text box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e)
    {

      try
      {
        //If the given file path doesn't exist
        if (!File.Exists(FullFilePath))
        {
          
          // Create an instance of the stream writer
          StreamWriter outputfile;


          //Create the file and put it in a specific location
          outputfile = File.CreateText(FullFilePath);
          //Close the file
          outputfile.Close();
        }
      }
      //Pops the exception and shows an erro message
      catch( Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      //Hey look a new stream reader
      StreamReader inputFile;

      try
      {
        //Open file from its location
        inputFile = File.OpenText(FullFilePath);
        //Loop through text file
        while (!inputFile.EndOfStream)
        {
          //Write items to list box
          ListBoxAnswers.Items.Add(inputFile.ReadLine());
        }

        // Close the text file
        inputFile.Close();
      }
      //exception with message box
      catch (Exception ex)
      {

        MessageBox.Show(ex.Message);
      }

    }
    /// <summary>
    /// Closes the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnExit_Click(object sender, EventArgs e)
    {
      //Close the form
      this.Close();
    }
  }
}
