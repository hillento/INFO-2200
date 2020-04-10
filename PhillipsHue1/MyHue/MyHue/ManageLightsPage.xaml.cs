using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using MyHue.Data;
using Newtonsoft.Json.Linq;

namespace MyHue
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ManageLightsPage : ContentPage
	{
		public ManageLightsPage ()
		{
			InitializeComponent ();
      //LoadLights Method
      LoadLights();
		}

    //Adds a button and slider fro ever Hue light connected to the hue bridge
    private void LoadLights()
    {
      //new Web Client named wc
      using(WebClient wc = new WebClient())
      {
        //Downloads the json proveded from the http request
        var json = wc.DownloadString($"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights");
        //New json Objects
        JObject jo;
        JObject lightJo;

        //Try to parse the downloaded json into the json object
        try
        {
          jo = JObject.Parse(json);

          //new objects for buttons and sliders
          Button BtnLight;
          Slider LightSLider;

          //Creating a stack layout 
          StackLayout SLLights = new StackLayout
          {
            //padding or margins
            Padding = new Thickness(30, 60, 30, 0),
            //inside the padding we put put a text with a labe, margin and font size
            Children = {new Label {
                Text ="Activate Hue Lights",
                Margin = new Thickness(10,20),
                FontSize = 30} }
          };
          //Creates a list of the hugh lights we can find and stores them in the HueGV object
          HueGV.HueLights = new List<HueLight>();
          //For every light found in our json object
          foreach (var light in jo)
          {
            //Parses tries to parse the 'state' of the light (on or off) into a string then into a json object
            lightJo = JObject.Parse(light.Value["state"].ToString());
            //a bool with a little if statement. If the string from lightJo is 'on' then return true else return false
            bool lightOn = lightJo["on"].ToString() == "True" ? true : false;
            //gets the value of the brightness of each light as an int
            int brightness = int.Parse(lightJo["bri"].ToString());

            //Adds a light to the list with it'ss respective properties
            HueGV.HueLights.Add(new HueLight { On = lightOn, Brightness = brightness, LightId = light.Key });
            //A new button with the light's respecteve properties
            BtnLight = new Button
            {
              Text = $"Light {light.Key}",
              BackgroundColor = lightOn ? Color.Yellow : Color.SlateGray,
              TextColor = lightOn ? Color.SlateGray : Color.White,
              FontSize = 30,
              StyleId = light.Key
            };
            //A new slider with the a max and min value as well as the light's ID
            LightSLider = new Slider
            {
              StyleId = light.Key,
              Maximum = 254,
              Minimum = 1
            };
            
            //creating an event for the slider for when it changes
            LightSLider.ValueChanged += LightSLider_ValueChanged;

            //click event for the buttons
            BtnLight.Clicked += BtnLight_Clicked;
            //Adds the button and slider
            SLLights.Children.Add(BtnLight);
            SLLights.Children.Add(LightSLider);
          }

          //sets content
          Content = SLLights;
        }
        catch (Exception ex)
        {
          //if you can't parse the json
          DisplayAlert("Error", ex.Message, "Close");
        }
      }
    }
    /// <summary>
    /// Changes the light brightness when the slider changes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LightSLider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
      //parses the sender object to whichever sender you're using
      Slider currentSlider = (Slider)sender;
      //new web client
      using (WebClient wc = new WebClient())
      {
        //sends a request to the url
        wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
        //gets the hub url
        string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{currentSlider.StyleId}";
        //gets the html of the state
        string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{currentSlider.StyleId}/state";
        //sets the lightjson to the huburl
        var lightjson = wc.DownloadString(huburl);

        //sets the json objects
        JObject jo = JObject.Parse(lightjson);
        JObject lightState = JObject.Parse(jo["state"].ToString());
        //checks the light state, if it is on, set the on property to true
        HueGV.CurrentLight.On = lightState["on"].ToString() == "True" ? true : false;

        //turns the light on if it is off and you use the slider
        string jsonLightOn = HueGV.CurrentLight.On ? $"{{\"on\":true, \"bri\":{currentSlider.Value}}}" : "{\"on\":true}";
        wc.UploadString(html, "PUT", jsonLightOn);
      }
    }

    //when you press the light button
    private void BtnLight_Clicked(object sender, EventArgs e)
    {
      //sets the sender object as a button
      Button BtnCurLight = (Button)sender;
      //sets the currentlight property
      HueGV.CurrentLight = new HueLight();

      using (WebClient wc = new WebClient())
      {
        //
        wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
        //gets the hub url
        string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}";
        //gets the html of the state
        string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}/state";
        //sets the lightjson to the huburl
        var lightjson = wc.DownloadString(huburl);

        //sets your light on state and json object like the slider
        JObject jo = JObject.Parse(lightjson);
        JObject lightState = JObject.Parse(jo["state"].ToString());
        //turns ligt on if off and off if on
        HueGV.CurrentLight.On = lightState["on"].ToString() == "True" ? true : false;

        //gets if the light is on or off
        string jsonLightOn = HueGV.CurrentLight.On ? "{\"on\":false}" : "{\"on\":true}";
        wc.UploadString(html, "PUT", jsonLightOn);
        //changes the light color besed of the stat of the light
        BtnCurLight.BackgroundColor = HueGV.CurrentLight.On ? Color.Yellow : Color.SlateGray;
        //changes the text color based on the state of the light
        BtnCurLight.TextColor = HueGV.CurrentLight.On ? Color.SlateGray : Color.White;
      }
    }
  }
}