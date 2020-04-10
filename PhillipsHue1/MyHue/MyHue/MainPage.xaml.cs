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
    //initialize variables
    string fileIp = "";
    string fileUser = "";
    public MainPage()
    {
      InitializeComponent();

      //sets your text files with their paths
      string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      string docName = "HueIp.txt";
      string docUser = "HueUser.txt";
      fileIp = Path.Combine(docPath, docName);
      fileUser = Path.Combine(docPath, docUser);
      //method call
      LoadIp();
      //if your ip isn't null or an empty string
      if (HueGV.HubIp != "" || HueGV.HubIp != null)
      {
        //go to create user method
        CreateUser();
      }
      else
      {
        //or display this message
        DisplayAlert("No Hub", "No Hub found on the network", "Close");
      }
    }
    //sets the controls fro the app
    private void DisplayControls()
    {
      //Sets the label to your hub ip address
      LblHueIp.Text = HueGV.HubIp;
      //sets the label to your user ID
      LblHueUser.Text = HueGV.HubUser;
      //changes the label to your desired string
      LblInfo.Text = "Manage your lights by clicking the buton below";
      //hides one button and shows another
      BtnHubPressed.IsVisible = false;
      BtnManageLights.IsVisible = true;
    }

    /// <summary>
    /// creates a user if you don't already have one
    /// </summary>
    private void CreateUser()
    {
      //if your file user exists
      if (File.Exists(fileUser))
      {
        //reade all of it (load into memory)
        HueGV.HubUser = File.ReadAllText(fileUser);
        //and display controls
        DisplayControls();
      }
      else
      {
        //using a web client
        using (WebClient wc = new WebClient())
        {
          //2 new strings
          string jsonbody = "{\"devicetype\":\"kodey_hue_app#iphone kodey\"}";
          string apiUrl = $"http://{HueGV.HubIp}/api";

          //sends a request tothe url to get a user
          wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
          //sets a string to store our request response
          string htmlRequest = wc.UploadString(apiUrl, jsonbody);
          //a json array that stores the response of your html request
          JArray ja = JArray.Parse(htmlRequest);

          //splits the json array into a string array
          string[] key = ja.First.First.Path.Split('.');
          //a switch based on the last index in the key array
          switch (key[key.Length -1])
          {
            //if it says error it returns a message and makes a button visible
            case "error":
              LblInfo.Text = "Please press the Hue Hub button";
              BtnHubPressed.IsVisible = true;
              break;
              //if it says success it changes the labels text and sets your HueGV user property and makes your manage light button visible
            case "success":
              LblInfo.Text = "Your ready to manage the lights";
              JObject jo = JObject.Parse(ja.First["success"].ToString());
              HueGV.HubUser = jo["username"].ToString();
              LblHueUser.Text = HueGV.HubUser;
              File.WriteAllText(fileUser, HueGV.HubUser);
              BtnManageLights.IsVisible = true;
              break;
            default:
              break;
          }
        }
      }
    }
    /// <summary>
    /// gets the ip address
    /// </summary>
    private void LoadIp()
    {
      //if the file already has the ip address...
      if (File.Exists(fileIp))
      {
        //sets the HubIp variabnle to the text in the file
        HueGV.HubIp = File.ReadAllText(fileIp);
        //new string storing the result of PingHostAddress
        string currentip = PingHostAddress();
        if (HueGV.HubIp != currentip)
        {
          //sets the global variable hub ip to the current ip
          HueGV.HubIp = currentip;
        }
      }
      else
      {
        //tries to set the Hub ip thorugh a direct ping
        HueGV.HubIp = PingHostAddress();
      }
    }
    /// <summary>
    /// Pings the hub to get get ip address
    /// </summary>
    /// <returns></returns>
    private string PingHostAddress()
    {
      // sets the object of IPAddress to null
      IPAddress ip = null;

      //tries to get the ip
      try
      {//gets the ip from the hub directly
        ip = Dns.GetHostEntry("huehubinfo.ad.uvu.edu").AddressList[0];
         //sets your global variable and writes the ipaddress to the text file
        HueGV.HubIp = ip.ToString();
        File.WriteAllText(fileIp, ip.ToString());
        //returns the ip address as a string
        return ip.ToString();
      }
      catch (Exception ex)
      {
        //If it cannot get the address it throws an error
        DisplayAlert("Error", ex.Message, "Close");
      }
      //returns and empty string
      return "";
    }
    //if your press the HubPressed button it calls the create user method
    private void BtnHubPressed_Clicked(object sender, EventArgs e)
    {
      CreateUser();
    }
    //if you click the managelights button it opens your manage lights page
    private void BtnManageLights_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ManageLightsPage());
    }
  }
}
