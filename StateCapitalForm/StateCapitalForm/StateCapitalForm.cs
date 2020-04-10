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

namespace StateCapitalForm
{
  public partial class StateCapitalForm : Form
  {
    //Create strings that make up the file path
    string filename = "StatesCapitals.txt";
    string filepath;
    string fullfilepath;
    

    public StateCapitalForm()
    {
      InitializeComponent();
      //Finds the curernt user from the system and saves it as a variable
      string Currentuser = Environment.UserName;
      //makes the file path include the currentuser variable
      filepath = $@"C:\users\{Currentuser}\Documents\";
      //Creates the full filepath
      fullfilepath = filepath + filename;
    }
    /// <summary>
    /// Take users input and add it to list box, sort the box, then save it to file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSubmit_Click(object sender, EventArgs e)
    {
      //Tests if Both text boxes have text in them
      if(TxtboxCapital.Text != "" && TxtboxState.Text != "")
      {
        //Make a string from the txtboxes
        string statecap = $"{TxtboxState.Text},{TxtboxCapital.Text}";
        //Add the statecap string to the listbox
        listBox1.Items.Add(statecap);
        //sort the list box
        listBox1.Sorted = true;
        //Method call for savestateandcap
        SaveStateandCap(statecap);
        //Pops up a message when you successfully add a state and capital
        MessageBox.Show($"Thank you for entering {TxtboxState.Text} stat and {TxtboxCapital.Text} capital");
        //clears the text boxes
        TxtboxState.Clear();
        TxtboxCapital.Clear();
        //puts the cursor back to the state text box
        TxtboxState.Focus();

      }
      //if either text box has an empty string
      else
      {
        //error message populates
        MessageBox.Show("Please Enter the stat and the capital", "Invalid Input");
      }
    }

    /// <summary>
    /// Method to append the text from the text boxes and then save and close the file
    /// </summary>
    /// <param name="statecap"></param>
    private void SaveStateandCap(string statecap)
    {
      try
      {
        //creates a streamwriter called output and appends the text box text to the file
        StreamWriter outputfile = File.AppendText(fullfilepath);
        outputfile.WriteLine(statecap);
        //close the file
        outputfile.Close();
      }
      catch (Exception ex)
      {
        //If your cannot find the file populate error
        MessageBox.Show(ex.Message);
      }
      
    }

    /// <summary>
    /// Loads the form and fills the listbox with the text in the file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StateCapitalForm_Load(object sender, EventArgs e)
    {
      
      //tries to find the file and make the file if it doesn't exist. If the directory cannot be made then it catches
      try
      {
        //creates a StreamReader called inputfile
        StreamReader inputfile;

        if (!Directory.Exists(filepath))
        {
          Directory.CreateDirectory(filepath);
        }

        if (!File.Exists(fullfilepath))
        {

          StreamWriter outputfile;
          outputfile = File.CreateText(fullfilepath);
          outputfile.Close();
        }
        

        inputfile = File.OpenText(fullfilepath);

        //while the file still has lines to read
        while (!inputfile.EndOfStream)
        {
          //add each line to the list box
          listBox1.Items.Add(inputfile.ReadLine());
        }
        //close the file
        inputfile.Close();
      }

      //Shows and error message if it cannot find or create the directory and file
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
