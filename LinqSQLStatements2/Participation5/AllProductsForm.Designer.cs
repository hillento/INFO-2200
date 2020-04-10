namespace Participation5
{
  partial class AllProductsForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.DgvProducts = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtBoxSearch = new System.Windows.Forms.TextBox();
      this.btnAddProduct = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
      this.SuspendLayout();
      // 
      // DgvProducts
      // 
      this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvProducts.Location = new System.Drawing.Point(12, 12);
      this.DgvProducts.Name = "DgvProducts";
      this.DgvProducts.Size = new System.Drawing.Size(639, 327);
      this.DgvProducts.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(54, 374);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(217, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Search Descriptions: ";
      // 
      // TxtBoxSearch
      // 
      this.TxtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtBoxSearch.Location = new System.Drawing.Point(277, 371);
      this.TxtBoxSearch.Name = "TxtBoxSearch";
      this.TxtBoxSearch.Size = new System.Drawing.Size(338, 31);
      this.TxtBoxSearch.TabIndex = 2;
      this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
      // 
      // btnAddProduct
      // 
      this.btnAddProduct.Location = new System.Drawing.Point(277, 408);
      this.btnAddProduct.Name = "btnAddProduct";
      this.btnAddProduct.Size = new System.Drawing.Size(337, 24);
      this.btnAddProduct.TabIndex = 3;
      this.btnAddProduct.Text = "Add New Product";
      this.btnAddProduct.UseVisualStyleBackColor = true;
      this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
      // 
      // AllProductsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 450);
      this.Controls.Add(this.btnAddProduct);
      this.Controls.Add(this.TxtBoxSearch);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DgvProducts);
      this.Name = "AllProductsForm";
      this.Text = "AllProductsForm";
      this.Load += new System.EventHandler(this.AllProductsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView DgvProducts;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtBoxSearch;
    private System.Windows.Forms.Button btnAddProduct;
  }
}