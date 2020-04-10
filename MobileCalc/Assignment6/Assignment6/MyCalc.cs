using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
  public class MyCalc
  {
    /// <summary>
    /// Translates the characters that are used in the labels ( multiply and divide) to the math operators
    /// </summary>
    /// <param name="buttonText"></param>
    /// <returns></returns>
    public string GetMathop(string buttonText)
    {
      //asci division symbol is a slash
      return buttonText == "÷" ? "/" :
        //little x is turned to an asterisc
          buttonText == "×" ? "*" : buttonText;
    }


    /// <summary>
    /// A switch case to do the math operation based on the operator chosen
    /// </summary>
    /// <param name="firstnum">User First Number</param>
    /// <param name="secondNum">User Second Number</param>
    /// <param name="MathOp">Math Operator</param>
    /// <returns></returns>
    public string Calculate(double firstnum, double secondNum, string MathOp)
    {
      switch (MathOp)
      {
        //if the operator is divide, divide first number by second
        case "/":
          return (firstnum / secondNum).ToString();
        //if the operator is multiply, multiply first number by second

        case "*":
          return (firstnum * secondNum).ToString();
        //if the operator is add, add first number by second

        case "+":
          return (firstnum + secondNum).ToString();
        //if the operator is subtract, subtract first number by second

        case "-":
          return (firstnum - secondNum).ToString();
          //default operator is null string
        default:
          return "";
      }
    }
  }
}
