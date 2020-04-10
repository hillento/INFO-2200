using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation5
{
  public partial class AddProductForm : Form
  {
    KodeysProductDb db = new KodeysProductDb();
    public AddProductForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Populates data grid with category counts
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddProductForm_Load(object sender, EventArgs e)
    {
      //var Categories = (from prod in db.Products
      //                            where prod.Category != null
      //                            group prod.Category by prod.Category into cats
      //                            select new { Category = cats.Key }).ToList();


      //lambda expression to select the categories and group them
      var categories = db.Products.Where(prod => prod.Category != null).GroupBy(prod => prod.Category);

      //cbCategory.Items.AddRange(Categories.Select(x => x.Category).ToArray());
    }

    /// <summary>
    /// Adds new item to the db
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSave_Click(object sender, EventArgs e)
    {
      //initializes variables
      string productNum = "", description = "";

      //if the method returns true
      if (ValidateProductNum(ref productNum))
      {
        //validates the category string by making sure you've selected something from the combobox, otherwise return an empty string for category
        string category = cbCategory.SelectedIndex >= 0 ? cbCategory.SelectedItem.ToString() : "";
        //validates the price by trying to convert the price text box to a decimal if not put 0
        decimal price = decimal.TryParse(txtbxPrice.Text, out price) ? price : 0;
        //validates the uoh by trying to convert the price text box to a int if not put 0
        int uoh = int.TryParse(txtbxUOH.Text, out uoh) ? uoh : 0;

        //initialize new class and set the properties 
        Product product = new Product
        {
          //setting the class properties 
          Product_Number = productNum,
          Description = txtbxDescription.Text,
          Category = category,
          Units_On_Hand = int.Parse(txtbxUOH.Text),
          Price = price
        };

        //adds the object to the database
        db.Products.Add(product);
        //saves the database
        db.SaveChanges();
        //closees the form
        Close();
      }
    }
    /// <summary>
    /// Validates the product number
    /// </summary>
    /// <param name="productNum"></param>
    /// <returns></returns>
    private bool ValidateProductNum(ref string productNum)
    {
      //If the text is more than 0 but less than 5 digits
      if (txtProductNum.Text.Count() <= 5 && txtProductNum.Text.Count() > 0)
      {
        //set the product number to the text box text and return true
        productNum = txtProductNum.Text;
        return true;
      }
      else
      {
        //show an error message and return false
        MessageBox.Show("Please enter a number from 1 to 5 digits");
        return false;
      }

    }
  }
}
