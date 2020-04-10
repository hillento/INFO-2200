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
  public partial class CategoryForm : Form
  {
    KodeysProductDb db = new KodeysProductDb();

    public CategoryForm()
    {
      InitializeComponent();
      LvCategories.Columns.Add("Category");
      LvCategories.Columns.Add("Count");
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
      //List<CategoryTotal> prodTotals = (from cat in db.Products
      //                                  group cat.Category by cat.Category into c
      //                                  select new CategoryTotal
      //                                  {
      //                                    Category = c.Key, CatCount = c.Count()
      //                                  }).ToList();
      List<CategoryTotal> catTotals = db.Products.GroupBy(cat => cat.Category)
        .Select(c => new CategoryTotal { Category = c.Key, CatCount = c.Count() }).ToList();

      foreach (CategoryTotal item in catTotals)
      {
        string[] listValue = { item.Category, item.CatCount.ToString() };
        ListViewItem listViewItem = new ListViewItem(listValue);
        LvCategories.Items.Add(listViewItem);
      }
      LvCategories.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
      LvCategories.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
    }
  }
}
