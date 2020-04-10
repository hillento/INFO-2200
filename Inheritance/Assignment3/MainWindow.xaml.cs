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

namespace Assignment3
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    //creates 3 animal objects
    Animal animal1;
    Animal animal2;
    Animal animal3;

    public MainWindow()
    {
      InitializeComponent();
      //assigns the animal objects to the 3 different child classes created for it with their respective skin and food types
      animal1 = new Beholder("Slimey?", "They don't seem to need food");
      animal2 = new Dragon("Scaley", "Annoying adventurers mostly");
      animal3 = new Sphinx("Furry","Small animals and the occasional Adventurer");
      //upon loading it checks the beholder radio button
      radBeholder.IsChecked = true;

    }

    /// <summary>
    /// Will populate the label at the bottom of the box with the SKINTYPE of the selected animal
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SkinType_Click(object sender, RoutedEventArgs e)
    {
      //if the beholder radio button is checked...
      if (radBeholder.IsChecked == true)
      {
        //Change the label text to the correct food type based on the animal1 skintype property result
        lblText.Content = animal1.SkinType;
      }
      //if the dragon radio button is checked...
      else if (radDragon.IsChecked == true)
      {
        //Change the label text to the correct food type based on the animal2 skintype property result
        lblText.Content = animal2.SkinType;
      }
      //if the Sphinx radio button is checked...
      else if (radSphinx.IsChecked == true)
      {
        //Change the label text to the correct food type based on the animal3 skintype property result
        lblText.Content = animal3.SkinType;
      }
      //if somehow no radio buttons are checked...
      else
      {
        MessageBox.Show("Don't know how I got here");
      }
    }

    /// <summary>
    /// Will populate the label at the bottom of the box with the FOODTYPE of the selected animal
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnFoodType_Click(object sender, RoutedEventArgs e)
    {
      //if the beholder radio button is checked...
      if (radBeholder.IsChecked == true)
      {
        //Change the label text to the correct food type based on the animal1 foodtype property result
        lblText.Content = animal1.FoodType;
      }
      //if the dragon radio button is checked...
      else if (radDragon.IsChecked == true)
      {
        //Change the label text to the correct food type based on the animal2 foodtype property result
        lblText.Content = animal2.FoodType;
      }
      //if the Sphinx radio button is checked...
      else if (radSphinx.IsChecked == true)
      {
        //Change the label text to the correct food type based on the animal3 foodtype property result
        lblText.Content = animal3.FoodType;
      }
      //if somehow no radio buttons are checked...
      else
      {
        MessageBox.Show("Don't know how I got here");
      }
    }

    /// <summary>
    /// Will populate the label at the bottom of the box with the EAT STRING of the Animal Class
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnEat_Click(object sender, RoutedEventArgs e)
    {
      //if the beholder radio button is checked...
      if (radBeholder.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal1 eat method result
        lblText.Content = animal1.Eat();
      }
      //if the dragon radio button is checked...
      else if (radDragon.IsChecked == true)
      {
        //Change the label text to the correct eat messagebased on the animal2 eat method result
        lblText.Content = animal2.Eat();
      }
      //if the Sphinx radio button is checked...
      else if (radSphinx.IsChecked == true)
      {
        //Change the label text to the correct eat messagebased on the animal3 eat method result
        lblText.Content = animal3.Eat();
      }
      //if somehow no radio buttons are checked...
      else
      {
        MessageBox.Show("Don't know how I got here");
      }
    }

    /// <summary>
    /// Will populate the label at the bottom of the box with the MOVE STRING of the Animal Class
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnMove_Click(object sender, RoutedEventArgs e)
    {
      //if the beholder radio button is checked...
      if (radBeholder.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal1 move virtual method result
        lblText.Content = animal1.Move();
      }
      //if the dragon radio button is checked...
      else if (radDragon.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal2 move virtual method result
        lblText.Content = animal2.Move();
      }
      //if the Sphinx radio button is checked...
      else if (radSphinx.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal3 move virtual method result
        lblText.Content = animal3.Move();
      }
      //if somehow no radio buttons are checked...
      else
      {
        MessageBox.Show("Don't know how I got here");
      }
    }

    /// <summary>
    /// Will populate the label at the bottom of the box with the REPRODUCE STRING of the Animal Class
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnReproduce_Click(object sender, RoutedEventArgs e)
    {
      //if the beholder radio button is checked...
      if (radBeholder.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal1 reproduce method result
        lblText.Content = animal1.Reproduce();
      }
      //if the dragon radio button is checked...
      else if (radDragon.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal2 reproduce method result
        lblText.Content = animal2.Reproduce();
      }
      //if the Sphinx radio button is checked...
      else if (radSphinx.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal3 reproduce method result
        lblText.Content = animal3.Reproduce();
      }
      //if somehow no radio buttons are checked...
      else
      {
        MessageBox.Show("Don't know how I got here");
      }
    }

    /// <summary>
    /// Will populate the label at the bottom of the box with the UNIQUE STRING of the selected animal
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnUnique_Click(object sender, RoutedEventArgs e)
    {
      //if the beholder radio button is checked...
      if (radBeholder.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal1 unique abstract method result
        lblText.Content = animal1.Unique();
      }
      //if the dragon radio button is checked...
      else if (radDragon.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal1 unique abstract method result
        lblText.Content = animal2.Unique();
      }
      //if the Sphinx radio button is checked...
      else if (radSphinx.IsChecked == true)
      {
        //Change the label text to the correct eat message based on the animal1 unique abstract method result
        lblText.Content = animal3.Unique();
      }
      //if somehow no radio buttons are checked...
      else
      {
        //Change the label text to the correct eat message based on the animal1 unique abstract method result
        MessageBox.Show("Don't know how I got here");
      }
    }

    /// <summary>
    /// Shows the DRAGON image 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Dragon_Checked(object sender, RoutedEventArgs e)
    {
      //picBeholder becomes hidden
      picBeholder.Visibility = Visibility.Hidden;
      //picDragon becomes visible
      picDragon.Visibility = Visibility.Visible;
      //picBeholder becomes hidden
      picSphinx.Visibility = Visibility.Hidden;
    }

    /// <summary>
    /// Shows the SPHINX image 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Sphinx_Checked(object sender, RoutedEventArgs e)
    {
      //picBeholder becomes hidden
      picBeholder.Visibility = Visibility.Hidden;
      //picDragon becomes hidden
      picDragon.Visibility = Visibility.Hidden;
      //picSphinx becomes Visible
      picSphinx.Visibility = Visibility.Visible;
    }

    /// <summary>
    /// Shows the BEHOLDER image 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Beholder_Checked(object sender, RoutedEventArgs e)
    {
      //picBeholder becomes Visible
      picBeholder.Visibility = Visibility.Visible;
      //picDragon becomes hidden
      picDragon.Visibility = Visibility.Hidden;
      //picSphinx becomes hidden
      picSphinx.Visibility = Visibility.Hidden;
    }
  }
}
