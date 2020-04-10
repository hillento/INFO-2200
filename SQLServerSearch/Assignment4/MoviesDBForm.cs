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
  public partial class MoviesDBFOrm : Form
  {
    public MoviesDBFOrm()
    {
      InitializeComponent();
    }  

    
    //upon loading fill the datatable with all columns and rows in the table
    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'moviesDataSet.Movie' table. You can move, or remove it, as needed.
      this.movieTableAdapter.Fill(this.moviesDataSet.Movie);

    }


   /// <summary>
   /// SHows the movies that have titels containing the text in the search text box
   /// </summary>
   /// <param name="sender"></param>
   /// <param name="e"></param>
    private void btnSearch_Click(object sender, EventArgs e)
    {
      //uses the created sql query to show any movie title containing the text in the text box
      this.movieTableAdapter.FillBySearch(this.moviesDataSet.Movie, txtbxSearch.Text);
    }
    /// <summary>
    /// Resets all filters and shows all movies
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnShowAll_Click(object sender, EventArgs e)
    {
      //Fills the datatable with the defailt select all query
      this.movieTableAdapter.Fill(this.moviesDataSet.Movie);
    }
    /// <summary>
    /// opens a new form showing the number of movies in each category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCatCount_Click(object sender, EventArgs e)
    {
      //Creates a new object of the type catcountform named countForm
      CatCountForm countForm = new CatCountForm();
      //Shows the new form
      countForm.Show();

    }
    /// <summary>
    /// Closes the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnExit_Click(object sender, EventArgs e)
    {
      //Closes the form
      Close();
    }
  }
}
