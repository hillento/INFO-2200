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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    /// <summary>
    /// shows the allproducts form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnProducts_Click(object sender, EventArgs e)
    {
      AllProductsForm allProductsForm = new AllProductsForm();
      allProductsForm.ShowDialog();
    }
    /// <summary>
    /// shows the category form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnCategories_Click(object sender, EventArgs e)
    {
      CategoryForm categoryForm = new CategoryForm();
      categoryForm.ShowDialog();
    }
  }
}
