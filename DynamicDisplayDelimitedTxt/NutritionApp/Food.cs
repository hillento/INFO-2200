using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionApp
{
    public class Food
    {
    /// <summary>
    /// Constructor Method with a string array input
    /// </summary>
    /// <param name="nutriFacts"></param>
    public Food(string[] nutriFacts)
    {
      //Set your variables to the cooresponding array index
      FoodName = nutriFacts[0];
      Calcium = double.Parse(nutriFacts[1]);
      ServingSize = nutriFacts[2];
      Weight = double.Parse(nutriFacts[3]);
      PercentWater = double.Parse(nutriFacts[4]);
      Energy = double.Parse(nutriFacts[5]);
      Protein = double.Parse(nutriFacts[6]);
      Carbohydrates = double.Parse(nutriFacts[7]);
      Fiber = double.Parse(nutriFacts[8]);
      Cholesterol = double.Parse(nutriFacts[9]);
      TotalFat = double.Parse(nutriFacts[10]);
      SaturatedFat = double.Parse(nutriFacts[11]);
      MonosatFat = double.Parse(nutriFacts[12]);
      Polyunsatfat = double.Parse(nutriFacts[13]);
      Iron = double.Parse(nutriFacts[14]);
      Magnesium = double.Parse(nutriFacts[15]);
      Sodium = double.Parse(nutriFacts[16]);
      Phosphorous = double.Parse(nutriFacts[17]);
      CaPRatio = double.Parse(nutriFacts[18]);
      Potassium = double.Parse(nutriFacts[19]);
      Zinc = double.Parse(nutriFacts[20]);
      Niacin = double.Parse(nutriFacts[21]);
      Thiamin = double.Parse(nutriFacts[22]);
      Riboflavin = double.Parse(nutriFacts[23]);
      VitA = double.Parse(nutriFacts[24]);
      VitB6 = double.Parse(nutriFacts[25]);
      VitC = double.Parse(nutriFacts[26]);
      FoodType = nutriFacts[27];

    }
    //All of the class variables
    public string FoodName { get; set; }
    public double Calcium { get; set; }
    public string ServingSize { get; set; }
    public double Weight { get; set; }
    public double PercentWater { get; set; }
    public double Energy { get; set; }
    public double Protein { get; set; }
    public double Carbohydrates { get; set; }
    public double Fiber { get; set; }
    public double Cholesterol { get; set; }
    public double TotalFat { get; set; }
    public double SaturatedFat { get; set; }
    public double MonosatFat { get; set; }
    public double Polyunsatfat { get; set; }
    public double Iron { get; set; }
    public double Magnesium { get; set; }
    public double Sodium { get; set; }
    public double Phosphorous { get; set; }
    public double CaPRatio { get; set; }
    public double Potassium { get; set; }
    public double Zinc { get; set; }
    public double Niacin { get; set; }
    public double Thiamin { get; set; }
    public double Riboflavin { get; set; }
    public double VitA { get; set; }
    public double VitB6 { get; set; }
    public double VitC { get; set; }
    public string FoodType { get; set; }
  }
}
