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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace NutritionApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    //Initializes the dictionary as a string and food object pair
    Dictionary<String, Food> FoodDict = new Dictionary<string, Food>();
    public MainWindow()
    {
      InitializeComponent();
      //Method calls for LoadFood and Center Window
      LoadFood();
      CenterWindow();
    }
    /// <summary>
    /// Finds the file in the bin and loads it into the array, dictionary, and combo box
    /// </summary>
    private void LoadFood()
    {
      //New streamreader called input file
      StreamReader inputfile;
      //new string array called temp food
      string[] tempFood;
      //try to open the file and read it
      try
      {
        //sets the input file to the text file called "nutrition.txt"
        inputfile = File.OpenText("nutrition.txt");
        //Reads the first line and moves to the second skipping the header and not putting it in the array
        inputfile.ReadLine();
        //while the file has more lines to read
        while (!inputfile.EndOfStream)
        {
          //sets the indexes of the array to each item in the list each tab in the file denotes a new index
          tempFood = inputfile.ReadLine().Split('\t');
          //adds the 0 index (first string) of the array to the combobox 
          cbFoods.Items.Add(tempFood[0]);
          //Adds the food name (0 index) as the first input in the dictionary and relates it to the newly created food object with the constructor taking the temp food array to set the properties
          FoodDict.Add(tempFood[0], new Food(tempFood));
        }
      }
      //if the file cannot be found
      catch (Exception ex)
      {
        //show the message wit the exception
        MessageBox.Show(ex.Message);
      }
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
    /// When an item from the combo box is selected: open the details window and populate the window's labels with the appropriate strings and numbers
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CbFoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      //If you can find the foodname in the dictionary...
      if(FoodDict.TryGetValue(cbFoods.SelectedItem.ToString(), out Food food))
      {
        //...Create a new detail window
        DetailsWindow foodDetails = new DetailsWindow();
        //Call the food details updateGUI method and put the variable food in the constructor
        foodDetails.UpdateGUI(food);
        //Shows the food Details window
        foodDetails.ShowDialog();
      }
      else
      {
        //Shows a message that tells you it cannot find the dictionary
        MessageBox.Show("Could not find in dictionary");
      }
    }
  }
}
