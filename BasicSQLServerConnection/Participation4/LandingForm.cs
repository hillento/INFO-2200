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
  public partial class LandingForm : Form
  {
    public LandingForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Shows a new localNumbers form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnLocalNumbers_Click(object sender, EventArgs e)
    {
      //Makes a new object from the localnumbersform class
      LocalNumberForm form2 = new LocalNumberForm();
      //shows the form2 object
      form2.Show();
    }
    /// <summary>
    /// Shows a new importedlNumbers form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnImportedNums_Click(object sender, EventArgs e)
    {
      //Makes a new object from the importednumbersform class
      ImportedNumbersForm Form1 = new ImportedNumbersForm();
      //shows the form1 object
      Form1.Show();
    }
    /// <summary>
    /// Shows a new onlineNumbers form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnOnlineNums_Click(object sender, EventArgs e)
    {
      //Makes a new object from the online numbersform class
      OnlineNumbersForm form3 = new OnlineNumbersForm();
      //shows the form3 object
      form3.Show();
    }
    /// <summary>
    /// closes the app
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClose_Click(object sender, EventArgs e)
    {
      //built in close method
      Close();
    }
  }
}
