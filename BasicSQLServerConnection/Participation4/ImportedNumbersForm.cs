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
  public partial class ImportedNumbersForm : Form
  {
    public ImportedNumbersForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Loads the data source and displays it in a data grid
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ImportedNumbersForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'uVUPhoneNumsDataSet11.UvuPhoneDirectory' table. You can move, or remove it, as needed.
      this.uvuPhoneDirectoryTableAdapter2.Fill(this.uVUPhoneNumsDataSet11.UvuPhoneDirectory);

    }
    /// <summary>
    /// Searches the first name column in the db and shows anything that has the typed string in the first name
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSerach_Click(object sender, EventArgs e)
    {
      //takes the current table adapter and fills it using the 'Fillby search' query
      this.uvuPhoneDirectoryTableAdapter2.FillBySearch(this.uVUPhoneNumsDataSet11.UvuPhoneDirectory, txtbxName.Text);
    }
    /// <summary>
    /// Orders the datagrid by last name in alphabetical order
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSortLast_Click(object sender, EventArgs e)
    {
      //takes the current tbale adapeter and fill it using the fillby last name query
      this.uvuPhoneDirectoryTableAdapter2.FillByLastNameOrder(this.uVUPhoneNumsDataSet11.UvuPhoneDirectory);
    }
    /// <summary>
    /// Shows only records with age over 30
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAgeOver30_Click(object sender, EventArgs e)
    {
      //takes the current tbale adapeter and fill it using the fillby Age over 30 query
      this.uvuPhoneDirectoryTableAdapter2.FillByAgeOver30(this.uVUPhoneNumsDataSet11.UvuPhoneDirectory);
    }
    /// <summary>
    /// Shows a message with the average age of the dataset
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAvgAge_Click(object sender, EventArgs e)
    {
      //creates a new decimal that can be converted from a DB and it's value comes from the fillbyavg age query
      decimal? average = this.uvuPhoneDirectoryTableAdapter2.FillByAvgAge();
      //Populates a message box showing the average age
      MessageBox.Show($"The average age is: {average.ToString()} ");
      //uses the avg age query on the phonetable adapter
      this.uvuPhoneDirectoryTableAdapter2.FillByAvgAge();
    }
    /// <summary>
    /// sets the data table back to defualt with no filters
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClear_Click(object sender, EventArgs e)
    {
      //takes the current tbale adapeter and fill it using the default fill to clear all filters
      this.uvuPhoneDirectoryTableAdapter2.Fill(this.uVUPhoneNumsDataSet11.UvuPhoneDirectory);
    }
  }
}
