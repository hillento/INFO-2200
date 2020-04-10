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

namespace Plants
{
  /// <summary>
  /// Interaction logic for PlantDetails.xaml
  /// </summary>
  public partial class PlantDetails : Window
  {
    //Creates a publically accessible object called plant that is a Plant type
    public Plant plant { get; set; }
    public PlantDetails()
    {
      InitializeComponent();
    }

    /// <summary>
    /// When you click the sniff button show your message for sniffing the plant
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSniff_Click(object sender, RoutedEventArgs e)
    {
      //populate a message box with the string returned from the Sniff method
      MessageBox.Show(plant.Sniff());
    }
    /// <summary>
    /// Close the window
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnClose_Click(object sender, RoutedEventArgs e)
    {
      //Close the window (built in method)
      Close();
    }
    /// <summary>
    /// Fills the labels of the instance of the details window with the appropriate text
    /// </summary>
    public void UpdateGUI()
    {//Adds text to each label based on the properties in the plant object
      lblEnvironment.Content = plant.Environment;
      lblName.Content = plant.Name;
      lblType.Content = plant.Type;
    }
  }
}
