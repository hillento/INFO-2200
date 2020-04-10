using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment6
{
  public partial class MainPage : ContentPage
  {
    //declare variables
    double firstNum = 0;
    double secondNum = 0;
    string mathOp = "";
    MyCalc myCalc = new MyCalc();
    int stage = -1;


    public MainPage()
    {
      InitializeComponent();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnOperator_Clicked(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      mathOp = myCalc.GetMathop(button.Text);
      stage = -2;
    }

    /// <summary>
    /// When you click a number if puts that number to the correct variable
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnNumber_Clicked(object sender, EventArgs e)
    {
      //new instance of button made from what the user pressed
      Button button = (Button)sender;
      //string
      string tempnum = "";

      //if the stage is -1 set the number to the first num variable and set the stage to 1 then display the number in the label
      if (stage == -1)
      {
        firstNum = Int64.Parse(button.Text);
        stage = 1;
        LblNumber.Text = firstNum.ToString();

      }
      //if the stage is 1 concatenate the selected number with the last number
      else if (stage == 1)
      {
        tempnum = LblNumber.Text + button.Text;
        firstNum = Int64.Parse(tempnum);
        LblNumber.Text = firstNum.ToString();
      }
      //If stage is -2 set the selected number to second number and display it on the label
      else if (stage == -2)
      {
        secondNum = Int64.Parse(button.Text);
        LblNumber.Text = secondNum.ToString();
        stage = 2;

      }
      //if the stage is 2 concatenate the selected number with the last number

      else if (stage == 2)
      {
        tempnum = LblNumber.Text + button.Text;
        secondNum = Int64.Parse(tempnum);
        LblNumber.Text = secondNum.ToString();
      }

     

    }



    /// <summary>
    /// calculates firstnum {operator} secondnum and displays it
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnEquals_Clicked(object sender, EventArgs e)
    {
      // sets the label to the result of the operation
      LblNumber.Text = myCalc.Calculate(firstNum, secondNum, mathOp);
      //sets the result of the previous calculation to first num
      firstNum = double.Parse(LblNumber.Text);
      //sets stage as if you've input the first number
      stage = 1;
    }

    /// <summary>
    /// Clears the calculator
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnCleared_Clicked(object sender, EventArgs e)
    {
      //sets all variables to 0 or blank
      firstNum = 0;
      secondNum = 0;
      mathOp = "";
      LblNumber.Text = "0";
    }

    
  }
}


