namespace Participation5
{
  partial class CategoryForm
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
      this.LvCategories = new System.Windows.Forms.ListView();
      this.BtnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LvCategories
      // 
      this.LvCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LvCategories.Location = new System.Drawing.Point(12, 12);
      this.LvCategories.Name = "LvCategories";
      this.LvCategories.Size = new System.Drawing.Size(401, 297);
      this.LvCategories.TabIndex = 0;
      this.LvCategories.UseCompatibleStateImageBehavior = false;
      this.LvCategories.View = System.Windows.Forms.View.Details;
      // 
      // BtnClose
      // 
      this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClose.Location = new System.Drawing.Point(12, 327);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(401, 111);
      this.BtnClose.TabIndex = 1;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = true;
      // 
      // CategoryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 450);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.LvCategories);
      this.Name = "CategoryForm";
      this.Text = "CategoryForm";
      this.Load += new System.EventHandler(this.CategoryForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView LvCategories;
    private System.Windows.Forms.Button BtnClose;
  }
}