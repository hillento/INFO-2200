using System;
using System.Collections.Generic;
using System.IO;
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

namespace MyPhones
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    Dictionary<String, Phone> PhoneDict = new Dictionary<string, Phone>();
    public MainWindow()
    {
      InitializeComponent();
      //Method calls
      LoadPhone();
      CenterWindow();
    }
    /// <summary>
    /// Centers the window in the same way as the details page refer there for more details
    /// </summary>
    private void CenterWindow()
    {
      double screenWidth = SystemParameters.PrimaryScreenWidth;
      double screenHeight = SystemParameters.PrimaryScreenHeight;
      double windowWidth = Width;
      double windowHeight = Height;
      Left = (screenWidth / 2) - (windowWidth / 2);
      Top = (screenHeight / 2) - (windowHeight / 2);
    }
    //upon loading, make a stream reader and read the file....
    private void LoadPhone()
    {
      //Reads the file
      StreamReader inputfile;
      //new array to store phone details
      string[] tempPhone;
      try
      {
        //tells which file to read
        inputfile = File.OpenText("phone.txt");
        //Reads the header line and steps down
        inputfile.ReadLine();
        //While we're not at the end of the file
        while (!inputfile.EndOfStream)
        {
          //Fill tempphone array with the lines from the text file delimited with a tab
          tempPhone = inputfile.ReadLine().Split('\t');
          //Add the phone name (index 1) to the dopdown box
          CbPhone.Items.Add(tempPhone[1]);
          //add the phone to the dictionary
          PhoneDict.Add(tempPhone[1], new Phone(tempPhone));

        }
      }
      //if the file isn't found show the error
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    /// <summary>
    /// When someone selects a phone from the list
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CbPhone_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      //if you can find the value in the dictionary output the Phone object called phone
      if (PhoneDict.TryGetValue(CbPhone.SelectedItem.ToString(), out Phone phone))
      {
        //New Phone details object
        PhoneDetails phoneDetails = new PhoneDetails();
        //Call the update gui method
        phoneDetails.UpdateGUI(phone);
        //Show the window for phone details;
        phoneDetails.ShowDialog();
      }
      else
      {
        // if you cannot find the phone in the dictionary then send error
        MessageBox.Show("Could not find in dictionary");
      }
    }
  }
}
