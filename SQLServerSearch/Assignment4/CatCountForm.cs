using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
  public partial class CatCountForm : Form
  {
    public CatCountForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// upon load show all rows and colums in the dataset in the data table
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CatCountForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'movieCatCount.MovieCategorySummary' table. You can move, or remove it, as needed.
      this.movieCategorySummaryTableAdapter.Fill(this.movieCatCount.MovieCategorySummary);

    }
    /// <summary>
    /// CLoses the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCatClose_Click(object sender, EventArgs e)
    {
      //Closes the form
      Close();
    }
  }
}
