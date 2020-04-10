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

namespace MyPhones
{
  /// <summary>
  /// Interaction logic for PhoneDetails.xaml
  /// </summary>
  public partial class PhoneDetails : Window
  {
    public PhoneDetails()
    {
      InitializeComponent();
      //Method to center the screen
      CenterWindow();
    }
    /// <summary>
    /// Finds the height and width of the window, then places the windows in the center
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
    /// Write to the labels in the window 
    /// </summary>
    /// <param name="phone"></param>
    public void UpdateGUI(Phone phone)
    {
      //Write to the labels based on the variables stored in the phone class
      LblBrand.Content = phone.Brand;
      LblDetails.Content = phone.Details;
      LblModel.Content = phone.Model;
      LblPrice.Content = phone.Price.ToString("c");
    }
  }
}
