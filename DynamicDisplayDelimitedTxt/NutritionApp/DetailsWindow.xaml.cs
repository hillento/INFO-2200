using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NutritionApp
{
  /// <summary>
  /// Interaction logic for DetailsWindow.xaml
  /// </summary>
  public partial class DetailsWindow : Window
  {
    public DetailsWindow()
    {
      InitializeComponent();
      CenterWindow();
    }
    /// <summary>
    /// Centers the window on the screen you're using
    /// </summary>
    private void CenterWindow()
    {
      //Find the height and width of the screen according to the system
      double screenWidth = SystemParameters.PrimaryScreenWidth;
      double screenHeight = SystemParameters.PrimaryScreenHeight;
      //variables for screen dimentions
      double windowWidth = Width;
      double windowHeight = Height;
      // Formula forscreen dimentions
      Left = (screenWidth / 2) - (windowWidth / 2);
      Top = (screenHeight / 2) - (windowHeight / 2);
    }
    /// <summary>
    /// Puts all the information from the Food class into the GUI Forms
    /// </summary>
    /// <param name="food"></param>
    public void UpdateGUI(Food food)
    {
      //Sets the content of each label to the cooresponding property of the Food app. All lines do the same thing 
      lblFoodName.Content = food.FoodName;
      lblFoodType.Content = food.FoodType;
      lblServingSize.Content = food.ServingSize;
      lblWeight.Content = food.Weight;
      lblCholesterol.Content = food.Cholesterol;
      lblPercentWater.Content = food.PercentWater;
      lblTotalFat.Content = food.TotalFat;
      lblCalories.Content = food.Energy;
      lblSaturatedFat.Content = food.SaturatedFat;
      lblProtein.Content = food.Protein;
      lblMonosatFat.Content = food.MonosatFat;
      lblPoluyunsatFat.Content = food.Polyunsatfat;
      lblCarbohydrates.Content = food.Carbohydrates;
      lblFiber.Content = food.Fiber;
      lblCalcium.Content = food.Calcium;
      lblZinc.Content = food.Zinc;
      lblIron.Content = food.Iron;
      lblNiacin.Content = food.Niacin;
      lblMagnesium.Content = food.Magnesium;
      lblThiamin.Content = food.Thiamin;
      lblSodium.Content = food.Sodium;
      lblRiboflavin.Content = food.Riboflavin;
      lblPhosphorous.Content = food.Phosphorous;
      lblVitaminA.Content = food.VitA;
      lblVitaminB6.Content = food.VitB6;
      lblVitaminC.Content = food.VitC;
      lblCaPRatio.Content = food.CaPRatio;
      lblPotassium.Content = food.Potassium;
    }
  }
}
