using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation4
{
  public partial class OnlineNumbersForm : Form
  {
    public OnlineNumbersForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Loads the data source and displays it in a data grid
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnlineNumbersForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'phoneListDbDataSet.Phone' table. You can move, or remove it, as needed.
      this.phoneTableAdapter.Fill(this.phoneListDbDataSet.Phone);
      

    }
    /// <summary>
    /// Searches the first name column in the db and shows anything that has the typed string in the first name
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSerach_Click(object sender, EventArgs e)
    {
      //takes the current table adapter and fills it using the 'Fillby search' query
      this.phoneTableAdapter.FillBySearch(this.phoneListDbDataSet.Phone, txtbxName.Text);
    }
    /// <summary>
    /// Orders the datagrid by last name in alphabetical order
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSortLast_Click(object sender, EventArgs e)
    {
      //takes the current tbale adapeter and fill it using the fillby last name query
      this.phoneTableAdapter.FillByLastNameSort(this.phoneListDbDataSet.Phone);
    }
    /// <summary>
    /// Shows only records with age over 30
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAgeOver30_Click(object sender, EventArgs e)
    {
      //takes the current tbale adapeter and fill it using the fillby Age over 30 query
      this.phoneTableAdapter.FillByAgeOver30(this.phoneListDbDataSet.Phone);
    }
    /// <summary>
    /// Shows a message with the average age of the dataset
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAvgAge_Click(object sender, EventArgs e)
    {
      //creates a new decimal that can be converted from a DB and it's value comes from the fillbyavg age query
      decimal? average = this.phoneTableAdapter.AvgAge();
      //Populates a message box showing the average age
      MessageBox.Show($"The average age is: {average.ToString()} ");
      //uses the avg age query on the phonetable adapter
      this.phoneTableAdapter.AvgAge();
    }
    /// <summary>
    /// sets the data table back to defualt with no filters
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClear_Click(object sender, EventArgs e)
    {
      //takes the current tbale adapeter and fill it using the default fill to clear all filters
      this.phoneTableAdapter.Fill(this.phoneListDbDataSet.Phone);
    }
  }
}
