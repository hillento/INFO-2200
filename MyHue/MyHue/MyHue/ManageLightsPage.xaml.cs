using MyHue.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyHue
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ManageLightsPage : ContentPage
  {
    //Variables initialized for the page
    int fullBrightness = 254;
    int hueGreen = 25000;
    int hueRed = 250;
    Button btnNightMode;
    Button btnFullBrightness;
    int nightBrightness = (int)Math.Ceiling(254 * .05);

    public ManageLightsPage()
    {
      InitializeComponent();
      //Load lights method call
      LoadLights();
    }

    /// <summary>
    /// Loads the controls for each light detected on your hub
    /// </summary>
    private void LoadLights()
    {
      //Using the web client.....
      using (WebClient wc = new WebClient())
      {
        //Pull the json from the hub with the list of lights and their state
        var json = wc.DownloadString($"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights");
        // Two json objects created
        JObject jo;
        JObject lightJo;

        //If it can parse the object to a JObject
        try
        {
          //sets jo to the Jobject
          jo = JObject.Parse(json);

          //initialize a bunch of controls
          Switch OnOffToggle;
          Slider sldrColor;
          Slider LightSlider;
          Button btnRed;
          Button btnGreen;
          Label LblName;
          Label lblOnOff;
          Label lblColorSlide;
          Label Dimmer;
          Grid LightGrid;


          //Creates a new stacklayout for the page
          StackLayout SLLights = new StackLayout
          {
            //Properties assigned to the stack layout
            Padding = new Thickness(30, 30, 30, 30),
            Children = { new Label {
              Text ="Active Hue Lights",
              Margin = new Thickness(10,10),
              FontSize = 30} }
          };

          //Creates a new list of Hue Lights 
          HueGV.HueLights = new List<HueLight>();

          //For each light in the Json string....
          foreach (var light in jo)
          {
            //...Get the lights state from the json object (ON/OFF, Brightness, Hue, Saturation, effect.....etc)
            lightJo = JObject.Parse(light.Value["state"].ToString());
            //bool based on the "on" property within state if "on" : true then true else false
            bool lightOn = lightJo["on"].ToString() == "True" ? true : false;
            //Gets the number value assigned to the brightness "bri": xxx
            int brightness = int.Parse(lightJo["bri"].ToString());
            //Gets the hue lights' color bosed on an int value "hue":xxxxx
            int hue = int.Parse(lightJo["hue"].ToString());

            //stores the 3 previous variable plus the light's key to the properties of each light
            HueGV.HueLights.Add(new HueLight { On = lightOn, Brightness = brightness, LightId = light.Key, Hue = hue });

            //Creates a label for each light assigned to the light, with the text Light {key} and font size of 20
            LblName = new Label
            {
              StyleId = light.Key,
              Text = $" Light {light.Key}:",
              FontSize = 20
            };

            //Another label with similar properties, just centered
            lblOnOff = new Label
            {
              StyleId = light.Key,
              Text = "On/Off:",
              FontSize = 30,
              HorizontalOptions = LayoutOptions.Center,
              VerticalOptions = LayoutOptions.Center
            };

            //A toggle button assigned to each light. Toggle is linked to the lightOn bool, it is centered vertically and horizontally
            OnOffToggle = new Switch
            {
              StyleId = light.Key,
              IsToggled = lightOn,
              HorizontalOptions = LayoutOptions.Start,
              VerticalOptions = LayoutOptions.Center
            };

            //A green button for each light. Colored green assigned to a specific light and with text
            btnGreen = new Button
            {
              Text = "Turn Light Green",
              BackgroundColor = Color.Green,
              StyleId = light.Key
            };
            //Same sort of button as above just red
            btnRed = new Button
            {
              Text = "Turn Light Red",
              BackgroundColor = Color.Red,
              StyleId = light.Key
            };

            //Another label, centered horizontally
            lblColorSlide = new Label
            {
              Text = "Color Selection Slider",
              HorizontalOptions = LayoutOptions.Center
            };

            //A slider with values from 0 to 655 and with hot pink on the left side of the thumbslider
            sldrColor = new Slider
            {
              StyleId = light.Key,
              Maximum = 655,
              Minimum = 0,
              MinimumTrackColor = Color.HotPink
            };

            //Another label, centered horizontally
            Dimmer = new Label
            {
              Text = "Brightness Slider",
              HorizontalOptions = LayoutOptions.Center
            };

            //A new slider with the a max and min value as well as the light's ID
            LightSlider = new Slider
            {
              StyleId = light.Key,
              Maximum = 254,
              Minimum = 1,
              MinimumTrackColor = Color.HotPink
            };


            //Greates a new grid with each light, 2 columns and 2 rows
            LightGrid = new Grid();
            //LightGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            LightGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            LightGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            // click events, toggle events and value changed events for the respective controls
            OnOffToggle.Toggled += OnOff_Clicked;
           btnGreen.Clicked += btnGreen_Clicked;
           btnRed.Clicked += btnRed_Clicked;
           sldrColor.ValueChanged += sldrColor_ValueChanged;
           LightSlider.ValueChanged += LightSLider_ValueChanged;

            //Adds new children to the stacklayout for each light
            SLLights.Children.Add(LblName);
            SLLights.Children.Add(LightGrid);
            //Adds children to the grid putting the elements in their respective column and row
            LightGrid.Children.Add(lblOnOff,0,0);
            LightGrid.Children.Add(OnOffToggle,1,0);
            LightGrid.Children.Add(btnGreen, 0, 1);
            LightGrid.Children.Add(btnRed, 1, 1);
            //Adds new children to the stacklayout for each light
            SLLights.Children.Add(lblColorSlide);
            SLLights.Children.Add(sldrColor);
            SLLights.Children.Add(Dimmer);
            SLLights.Children.Add(LightSlider);

          }

          //a button on the bottom of the stack layout regardless of how many lights, starts as invisible
          btnFullBrightness = new Button
          {
            Text = "Full Brightness",
            IsVisible = false
          };
          //a button on the bottom of the stack layout regardless of how many lights, starts as visible
          btnNightMode = new Button
          {
            Text = "Night Mode",
            IsVisible = true
          };

          //Adds the above 2 buttons to the stacklayout and gives then click events
          SLLights.Children.Add(btnNightMode);
          btnNightMode.Clicked += NightMode_Clicked;
          SLLights.Children.Add(btnFullBrightness);
          btnFullBrightness.Clicked += FullBrightness_Clicked;
          //the content page contains the stacklayout
          Content = SLLights;
        }

        //If it cannot get the json file throw an error
        catch (Exception ex)
        {
          DisplayAlert("Error", ex.Message, "Close");
        }
      }
    }

    /// <summary>
    /// Changes the color of the light based on the slider position
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
   private void sldrColor_ValueChanged(object sender, ValueChangedEventArgs e)
    {
      //creates a new slider variable, based on the value of whichever slider you change
      Slider currentSlider = (Slider)sender;
      //Creates a light based on the light you are editing in the stack layout
      HueGV.CurrentLight = new HueLight();
      //using the webclient....
      using (WebClient wc = new WebClient())
      {
        //the header from the api
        wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
        //a string to get to the api and the specific light
        string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{currentSlider.StyleId}";
        // a string to get to the state of the specific light
        string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{currentSlider.StyleId}/state";
        //downloads the string recieved from the variable huburl
        var lightjson = wc.DownloadString(huburl);
        //New Json object from previous downloaded string
        JObject jo = JObject.Parse(lightjson);
        //gets the state of the light from the variable jo
        JObject lightState = JObject.Parse(jo["state"].ToString());
        //sets the on bool value based on the the "on": property of the light; if true, true else false
        HueGV.CurrentLight.On = lightState["on"].ToString() == "True" ? true : false;

        //Creates a string setting the on value to true and the hue value to the slider value *100
        //This makes for a less touchy and less sensitive slider by having less values for the slider. It still makes it through a very complete spectrum
        string jsonLightOn = $"{{\"on\":true, \"hue\":{currentSlider.Value * 100}}}";
        //Uploads the previous string to the api to change the light's color
        wc.UploadString(html, "PUT", jsonLightOn);
      }
    }

    /// <summary>
    /// Changes the slected light to red
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnRed_Clicked(object sender, EventArgs e)

    {//creates a new button variable, based on the value of whichever button you change
      Button BtnCurLight = (Button)sender;
      //Creates a light based on the light you are editing in the stack layout
      HueGV.CurrentLight = new HueLight();
      //using the webclient....
      using (WebClient wc = new WebClient())
      {
        //the header from the api
        wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
        //a string to get to the api and the specific light
        string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}";
        // a string to get to the state of the specific light's state
        string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}/state";
        //downloads the string recieved from the variable huburl
        var lightjson = wc.DownloadString(huburl);
        //New Json object from previous downloaded string
        JObject jo = JObject.Parse(lightjson);
        //gets the state of the light from the variable jo
        JObject lightState = JObject.Parse(jo["state"].ToString());
        //sets the on bool value based on the the "on": property of the light; if true, true else false
        HueGV.CurrentLight.On = lightState["on"].ToString() == "True" ? true : false;

        //Sets our body for the API
        string jsonLightOn = $"{{\"on\":true, \"hue\":{hueRed}}}";
        //Uploads our strings to the API using the put method
        wc.UploadString(html, "PUT", jsonLightOn);
      }
    }

    /// <summary>
    /// Changes the slected light to green
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnGreen_Clicked(object sender, EventArgs e)
    {
      //creates a new button variable, based on the value of whichever button you change
      Button BtnCurLight = (Button)sender;
      //Creates a light based on the light you are editing in the stack layout
      HueGV.CurrentLight = new HueLight();

      //using the webclient....
      using (WebClient wc = new WebClient())
      {
        //the header from the api
        wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
        //a string to get to the api and the specific light
        string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}";
        // a string to get to the state of the specific light's state
        string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}/state";
        //downloads the string recieved from the variable huburl
        var lightjson = wc.DownloadString(huburl);
        //New Json object from previous downloaded string
        JObject jo = JObject.Parse(lightjson);
        //gets the state of the light from the variable jo
        JObject lightState = JObject.Parse(jo["state"].ToString());
        //sets the on bool value based on the the "on": property of the light; if true, true else false
        HueGV.CurrentLight.On = lightState["on"].ToString() == "True" ? true : false;

        //Sets our body for the API
        string jsonLightOn = $"{{\"on\":true, \"hue\":{hueGreen}}}";
        //Uploads our strings to the API using the put method
        wc.UploadString(html, "PUT", jsonLightOn);
      }
    }

    /// <summary>
    /// Turns all lights on the hue hub to full brightness (254)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FullBrightness_Clicked(object sender, EventArgs e)
    {
      //creates a new button variable, based on the value of whichever button you change
      Button BtnCurLight = (Button)sender;

      //for each thing (we called light) in the HueGV.HueLights List...
      foreach (var light in HueGV.HueLights)
      {
        ////using the webclient....
        using (WebClient wc = new WebClient())
        {
          //the header from the api
          wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
          //a string to get to the api and the specific light
          string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{light.LightId}";
          // a string to get to the state of the specific light's state
          string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{light.LightId}/state";
          //downloads the string recieved from the variable huburl
          var lightjson = wc.DownloadString(huburl);
          
          //Makes sets the on property to true and the brightness to the fullBrightness Variable
          string jsonLightOn = $"{{\"on\":true, \"bri\":{fullBrightness}}}";
          //sends the json sting to the api using the put method
          wc.UploadString(html, "PUT", jsonLightOn);
        }
      }
      //Makes the NightMode button visible
      btnNightMode.IsVisible = true;
      //Hides the fill brightness button
      btnFullBrightness.IsVisible = false;
    }
    /// <summary>
    /// Turns all lights on the hub to 5% brightness (.05*254)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NightMode_Clicked(object sender, EventArgs e)
    {
      //creates a new button variable, based on the value of whichever button you change
      Button BtnCurLight = (Button)sender;

      //for each thing (we called light) in the HueGV.HueLights List...
      foreach (var light in HueGV.HueLights)
      {
        ////using the webclient....
        using (WebClient wc = new WebClient())
        {
          //the header from the api
          wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
          //a string to get to the api and the specific light
          string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{light.LightId}";
          // a string to get to the state of the specific light's state
          string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{light.LightId}/state";
          //downloads the string recieved from the variable huburl
          var lightjson = wc.DownloadString(huburl);

          //Makes sets the on property to true and the brightness to the nightBrightness Variable
          string jsonLightOn = $"{{\"on\":true, \"bri\":{nightBrightness}}}";
          //sends the json sting to the api using the put method
          wc.UploadString(html, "PUT", jsonLightOn);
        }
      }
      btnNightMode.IsVisible = false;
      btnFullBrightness.IsVisible = true;

    }

    private void OnOff_Clicked(object sender, ToggledEventArgs e)
    {
      //sets the sender object as a button to retrieve which button was pressed
      Switch BtnCurLight = (Switch)sender;
      //sets the currentlight property as a Hue Light
      HueGV.CurrentLight = new HueLight();

      //So we can send stuff to the API we use the web client
      using (WebClient wc = new WebClient())
      {
        //The header of our request
        wc.Headers[HttpRequestHeader.ContentType] = "application/x=www-form-urlencoded";
        //gets the hub url we're sending to
        string huburl = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}";
        //gets the html of the state
        string html = $"http://{HueGV.HubIp}/api/{HueGV.HubUser}/lights/{BtnCurLight.StyleId}/state";
        //sets the lightjson to the huburl
        var lightjson = wc.DownloadString(huburl);

        //sets your light on state and json object like the slider
        JObject jo = JObject.Parse(lightjson);
        JObject lightState = JObject.Parse(jo["state"].ToString());
        //Sets the on property to on if the light is on and off if the light is off
        HueGV.CurrentLight.On = lightState["on"].ToString() == "True" ? true : false;

        //Sends our string to the API and turns the light on or off
        string jsonLightOn = HueGV.CurrentLight.On ? "{\"on\":false}" : "{\"on\":true}";
        wc.UploadString(html, "PUT", jsonLightOn);
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
      //sets the currentlight property
      HueGV.CurrentLight = new HueLight();
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
        string jsonLightOn = HueGV.CurrentLight.On ? $"{{\"on\":true, \"bri\":{(int)currentSlider.Value}}}" : "{\"on\":true}";
        wc.UploadString(html, "PUT", jsonLightOn);
      }
    }
  }
}