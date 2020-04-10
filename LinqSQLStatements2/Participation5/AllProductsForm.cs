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
  public partial class AllProductsForm : Form
  {
    //creates a KodeysProductDB object
    KodeysProductDb db = new KodeysProductDb();

    public AllProductsForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Upon loading  the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AllProductsForm_Load(object sender, EventArgs e)
    {
      //Making a list of products from the database products colum
      List<Product> products = (from prod in db.Products
                                select prod).ToList();
      //populates the datagrid 
      DgvProducts.DataSource = products;
      //makes the columns the right width
      AdjustColumns();
    }
    /// <summary>
    /// makes columns the correct width
    /// </summary>
    private void AdjustColumns()
    {
      // count of the columns
      int count = DgvProducts.Columns.Count;
      //for the number of columns
      for (int i = 0; i < count; i++)
      {
        //set the width of the column to the appropriate size
        DgvProducts.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      }
    }

    /// <summary>
    /// Searches the DB
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
    {
      //new list of products from the database
      List<Product> products = (from prod in db.Products
                                where prod.Description.Contains(TxtBoxSearch.Text)
                                select prod).ToList();
      //lambda expression searches the db column description for the users input
      List<Product> prods = db.Products.Where(prod => prod.Description.Contains(TxtBoxSearch.Text)).ToList();

      //sets datagrid view
      DgvProducts.DataSource = products;
      //makes columns appropriate size
      AdjustColumns();
    }

    /// <summary>
    /// Adds a new product
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAddProduct_Click(object sender, EventArgs e)
    {
      // new add product form shows
      AddProductForm addProduct = new AddProductForm();
      addProduct.ShowDialog();

      //sets data grid view
      DgvProducts.DataSource = db.Products.ToList();
    }
  }
}
