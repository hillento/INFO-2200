using MyHue.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyHue
{
  public partial class MainPage : ContentPage
  {
    //Sets 2 empty strings to use later
    string fileIp = "";
    string fileUser = "";
    public MainPage()
    {
      InitializeComponent();

      //Sets the docPath string variable to the mydocuments folder on your device
      string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      //2 strings for file names
      string docName = "HueIp.txt";
      string docUser = "HueUser.txt";
      //combines the file names with the document path for a full address
      fileIp = Path.Combine(docPath, docName);
      fileUser = Path.Combine(docPath, docUser);

      //Sends us to the Load IP Method
      LoadIp();

      //If the ip is not an empty string or null
      if (HueGV.HubIp != "" || HueGV.HubIp != null)
      {
        //call create user method
        CreateUser();
      }
      //if they are null or empty string
      else
      {
        //Display this message box 
        DisplayAlert("No Hub", "No Hub found on the network", "Close");
      }
    }

    /// <summary>
    /// Loads the controls assuming there is a user and IP
    /// </summary>
    private void DisplayControls()
    {
      //If the user isn't an empty string or null this will open automatically to the manage lights page
      if (HueGV.HubUser != "" || HueGV.HubUser != null)
      {
        //Navigate to the open lights page
        Navigation.PushAsync(new ManageLightsPage());
      }
      //Sets the label to the string stored in HubIp
      LblHueIp.Text = HueGV.HubIp;
      //Sets teh label to the string stored in HubUser
      LblHueUser.Text = HueGV.HubUser;
      //Sets the text fro the lblInfo label
      LblInfo.Text = "Manage your lights by clicking the button below";
      //Hides the BtnHubPressed Button
      BtnHubPressed.IsVisible = false;
      //SHows the BtnManageLight button
      BtnManageLights.IsVisible = true;

    }
    /// <summary>
    /// Gets a random user 'name' from the hub for you
    /// </summary>
    private void CreateUser()
    {
      //if the fileUser file exists...
      if (File.Exists(fileUser))
      {
        //sets the Hubuser property to the text in the fileUser
        HueGV.HubUser = File.ReadAllText(fileUser);
        //goes to the displayControls property
        DisplayControls();
      }
      //if it doesn't exist
      else
      {
        //Using the web client....
        using (WebClient wc = new WebClient())
        {
          //Sets a string telling the api what your device is
          string jsonbody = "{\"devicetype\":\"kodey_hue_app#iphone kodey\"}";
          //sets a string to the api url
          string apiUrl = $"http://{HueGV.HubIp}/api";
          //using the web client sent the header
          wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
          //stores the response of the previous request
          string htmlRequest = wc.UploadString(apiUrl, jsonbody);

          //Makes an JArray names ja to store our response from the api
          JArray ja = JArray.Parse(htmlRequest);

          //splits the JArray by the '.' character
          string[] key = ja.First.First.Path.Split('.');
          //based on the last index of the key string array
          switch (key[key.Length - 1])
          {
            //if it says error the label will read "please press the hub button and make the HubPressed button visible
            case "error":
              LblInfo.Text = "Please press the Hue Hub button";
              BtnHubPressed.IsVisible = true;
              break;
              //If it says success it will change the text of the label...
            case "success":
              LblInfo.Text = "Your ready to manage the lights";
              //...initialize our jo JObject
              JObject jo = JObject.Parse(ja.First["success"].ToString());
              //Set our user to the user the hub sends to us
              HueGV.HubUser = jo["username"].ToString();
              //set the label text to the HubUser variable
              LblHueUser.Text = HueGV.HubUser;
              //Write the user to our fileUser text file
              File.WriteAllText(fileUser, HueGV.HubUser);
              //make the manage lights button visible
              BtnManageLights.IsVisible = true;
              break;
              //if neither, break
            default:
              break;
          }
        }
      }
    }
    /// <summary>
    /// IF you already have the IP it sets the IP global variable to the IP in the folder, else it finds the i in a different method
    /// </summary>
    private void LoadIp()
    {
      //If the file exists...
      if (File.Exists(fileIp))
      {
        //Sets the HubIP property to the full text of the file
        HueGV.HubIp = File.ReadAllText(fileIp);
        //a new string made by the ping host address method (should be an ip address for the hub)
        string currentip = PingHostAddress();
        //If they text and the ping are not the same
        if (HueGV.HubIp != currentip)
        {
          //Sets the HubIp property to the current IP obtained from the ping
          HueGV.HubIp = currentip;
        }
      }
      //....If not....
      else
      {
        //Set the IP what is obtained from the PingHostAddress method
        HueGV.HubIp = PingHostAddress();
      }
    }

    /// <summary>
    /// Uses a ping method to get the IP of the Hue Hub
    /// </summary>
    /// <returns></returns>
    private string PingHostAddress()
    {
      //Sets a null IP address type variable
      IPAddress ip = null;
      //tries to ping the indicated address on the network
      try
      {
        //Sets your IP to what is returned by the pinging method (get host entry)
        ip = Dns.GetHostEntry("hueapi.ad.uvu.edu").AddressList[0];
        //Sets your HubIp to the ip variable string (which should be the IP address of the indicated hub
        HueGV.HubIp = ip.ToString();
        //Writes the IP to the file "fileIp"
        File.WriteAllText(fileIp, ip.ToString());
        //Returns the ip address as a string
        return ip.ToString();
      }
      //If it cannot ping the host throw an exception and return an empty string
      catch (Exception ex)
      {
        //displays the error in a message box on the phone
        DisplayAlert("Error", ex.Message, "Close");
      }
      //returning an empty string
      return "";
    }

    /// <summary>
    /// If you don't yet have a user this button with fetch a random user from the Hue Hub
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnHubPressed_Clicked(object sender, EventArgs e)
    {
      //calls the create user method
      CreateUser();
    }

    /// <summary>
    /// Once you have a user and IP this will navigate you yo the new page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void BtnManageLights_Clicked(object sender, EventArgs e)
    {
      //navigates you to the ManageLightPage
      Navigation.PushAsync(new ManageLightsPage());
    }
  }
}
