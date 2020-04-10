namespace Participation5
{
  partial class MainForm
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
      this.BtnProducts = new System.Windows.Forms.Button();
      this.BtnCategories = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnProducts
      // 
      this.BtnProducts.Location = new System.Drawing.Point(12, 23);
      this.BtnProducts.Name = "BtnProducts";
      this.BtnProducts.Size = new System.Drawing.Size(201, 97);
      this.BtnProducts.TabIndex = 1;
      this.BtnProducts.Text = "All Products";
      this.BtnProducts.UseVisualStyleBackColor = true;
      this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
      // 
      // BtnCategories
      // 
      this.BtnCategories.Location = new System.Drawing.Point(12, 136);
      this.BtnCategories.Name = "BtnCategories";
      this.BtnCategories.Size = new System.Drawing.Size(201, 97);
      this.BtnCategories.TabIndex = 1;
      this.BtnCategories.Text = "Categories";
      this.BtnCategories.UseVisualStyleBackColor = true;
      this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Participation5.Properties.Resources.before;
      this.pictureBox1.Location = new System.Drawing.Point(-192, -49);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(972, 764);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(593, 483);
      this.Controls.Add(this.BtnCategories);
      this.Controls.Add(this.BtnProducts);
      this.Controls.Add(this.pictureBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "MainForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button BtnProducts;
    private System.Windows.Forms.Button BtnCategories;
  }
}

