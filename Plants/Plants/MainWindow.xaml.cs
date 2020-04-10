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

namespace Plants
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    //These are the 3 different libraries the detais will refer too
    Dictionary<string, Plant> PlantDict = new Dictionary<string, Plant>();

    public MainWindow()
    {
      InitializeComponent();
      
      PopulateComboBoxes();
    }

    private void PopulateComboBoxes()
    {//populates the environment combo box with these 4 specific options
      CbEnvironment.Items.Add("Forest");
      CbEnvironment.Items.Add("Desert");
      CbEnvironment.Items.Add("Tropical");
      CbEnvironment.Items.Add("House");
      //populates the type combo box with these 4 options
      CbType.Items.Add("Flower");
      CbType.Items.Add("Tree");
      CbType.Items.Add("Shrub");
    }
    /// <summary>
    /// Opens the details window with all the plant's details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
    {
      //if something is selected in the list box
      if (LstBoxPlants.SelectedIndex > -1)
      {
        //create a string that stores the text of the selected Item in the list box
        string key = LstBoxPlants.SelectedItem.ToString();
        //if the variable key can be found in the dictionary....
        if (PlantDict.TryGetValue(key, out Plant plant))
        {
          //Create a Plant Details window
          PlantDetails plantDetails = new PlantDetails();
          //feeds the main widnow's property of plant to rhe plant details property called plant
          plantDetails.plant = plant;
          //Update GUI method call
          plantDetails.UpdateGUI();
          //Shows the window that was creaded 3 lines ago
          plantDetails.Show();


        //  MessageBox.Show($"{plant.Type} Name:{plant.Name}\n" +
        //    $"Environment: {plant.Environment}\n" +
        //    $"Type:{plant.Type}\n");
        }
        else
        {
          //If the plant can't be found in the dictionary show this message
          MessageBox.Show("I don't know how I got here...");
        }
      }
      
    }
    /// <summary>
    /// Adds the name of the plant to the list box and to the dictionary
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
    {
      //As long as you've got text in the text box and selected things from the 2 drop downs...
      if (TxtBoxName.Text != "" && CbEnvironment.SelectedIndex != -1 && CbType.SelectedIndex != -1)
      {
        // create these strings variables from the text box and drop downs
        string plantName = TxtBoxName.Text;
        string environment = CbEnvironment.SelectedItem.ToString();
        string type = CbType.SelectedItem.ToString();
        //Creates a switch based on the type variable (which was taken from the drop down)
        switch (type)
        {
          //IF the type is flower... 
          case "Flower":
            //then create a Flower object and give it the name, environment and type attributes in the constructor
            Flower flower = new Flower(plantName, environment,type,"Red");
            //Add your plant name along with your new object to the plant dictionary
            PlantDict.Add(plantName, flower);
            //break from the swithc and move on
            break;
          //IF the type is Shrub... 
          case "Shrub":
            //then create a Shrub object and give it the name, environment and type attributes in the constructor
            Shrub shrub = new Shrub(plantName, environment, type, "Large");
            //Add your plant name along with your new object to the plant dictionary
            PlantDict.Add(plantName, shrub);
            //break from the swithc and move on
            break;
          //IF the type is Tree... 
          case "Tree":
            //then create a Shrub object and give it the name, environment and type attributes in the constructor
            Tree tree = new Tree(plantName, environment, type, "Needle");
            //Add your plant name along with your new object to the plant dictionary
            PlantDict.Add(plantName, tree);
            //break from the swithc and move on
            break;
            //IF the type isn't any of the above...
          default:
            //SHow this message
            MessageBox.Show("I'm not sure how I got here.");
            //break from the swithc and move on
            break;
        }
        //Add the plant name to the list box
        LstBoxPlants.Items.Add(plantName);
       
      }
      //If you haven't entered all the appropriate information or picked items from the dropdown
      else
      {
        //Show this message
        MessageBox.Show("Please enter all information for the plant.");
      }
    }
  }
}
