namespace Participation5
{
  partial class AddProductForm
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
      this.lblProductID = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.lblUnitsOnHand = new System.Windows.Forms.Label();
      this.lblPrice = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.cbCategory = new System.Windows.Forms.ComboBox();
      this.txtProductNum = new System.Windows.Forms.TextBox();
      this.txtbxDescription = new System.Windows.Forms.TextBox();
      this.txtbxUOH = new System.Windows.Forms.TextBox();
      this.txtbxPrice = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblProductID
      // 
      this.lblProductID.AutoSize = true;
      this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProductID.Location = new System.Drawing.Point(34, 37);
      this.lblProductID.Name = "lblProductID";
      this.lblProductID.Size = new System.Drawing.Size(81, 20);
      this.lblProductID.TabIndex = 0;
      this.lblProductID.Text = "ProductID";
      // 
      // lblDescription
      // 
      this.lblDescription.AutoSize = true;
      this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDescription.Location = new System.Drawing.Point(30, 95);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(89, 20);
      this.lblDescription.TabIndex = 1;
      this.lblDescription.Text = "Description";
      // 
      // lblUnitsOnHand
      // 
      this.lblUnitsOnHand.AutoSize = true;
      this.lblUnitsOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUnitsOnHand.Location = new System.Drawing.Point(17, 138);
      this.lblUnitsOnHand.Name = "lblUnitsOnHand";
      this.lblUnitsOnHand.Size = new System.Drawing.Size(114, 20);
      this.lblUnitsOnHand.TabIndex = 2;
      this.lblUnitsOnHand.Text = "Units On Hand";
      // 
      // lblPrice
      // 
      this.lblPrice.AutoSize = true;
      this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPrice.Location = new System.Drawing.Point(52, 174);
      this.lblPrice.Name = "lblPrice";
      this.lblPrice.Size = new System.Drawing.Size(44, 20);
      this.lblPrice.TabIndex = 3;
      this.lblPrice.Text = "Price";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(38, 208);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Category";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(158, 261);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(200, 47);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // cbCategory
      // 
      this.cbCategory.FormattingEnabled = true;
      this.cbCategory.Location = new System.Drawing.Point(158, 207);
      this.cbCategory.Name = "cbCategory";
      this.cbCategory.Size = new System.Drawing.Size(200, 21);
      this.cbCategory.TabIndex = 13;
      // 
      // txtProductNum
      // 
      this.txtProductNum.Location = new System.Drawing.Point(158, 37);
      this.txtProductNum.Name = "txtProductNum";
      this.txtProductNum.Size = new System.Drawing.Size(200, 20);
      this.txtProductNum.TabIndex = 14;
      // 
      // txtbxDescription
      // 
      this.txtbxDescription.Location = new System.Drawing.Point(158, 95);
      this.txtbxDescription.Name = "txtbxDescription";
      this.txtbxDescription.Size = new System.Drawing.Size(200, 20);
      this.txtbxDescription.TabIndex = 14;
      // 
      // txtbxUOH
      // 
      this.txtbxUOH.Location = new System.Drawing.Point(158, 138);
      this.txtbxUOH.Name = "txtbxUOH";
      this.txtbxUOH.Size = new System.Drawing.Size(200, 20);
      this.txtbxUOH.TabIndex = 14;
      // 
      // txtbxPrice
      // 
      this.txtbxPrice.Location = new System.Drawing.Point(158, 174);
      this.txtbxPrice.Name = "txtbxPrice";
      this.txtbxPrice.Size = new System.Drawing.Size(200, 20);
      this.txtbxPrice.TabIndex = 14;
      // 
      // AddProductForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 369);
      this.Controls.Add(this.txtbxPrice);
      this.Controls.Add(this.txtbxUOH);
      this.Controls.Add(this.txtbxDescription);
      this.Controls.Add(this.txtProductNum);
      this.Controls.Add(this.cbCategory);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblPrice);
      this.Controls.Add(this.lblUnitsOnHand);
      this.Controls.Add(this.lblDescription);
      this.Controls.Add(this.lblProductID);
      this.Name = "AddProductForm";
      this.Text = "AddProductForm";
      this.Load += new System.EventHandler(this.AddProductForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblProductID;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblUnitsOnHand;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.ComboBox cbCategory;
    private System.Windows.Forms.TextBox txtProductNum;
    private System.Windows.Forms.TextBox txtbxDescription;
    private System.Windows.Forms.TextBox txtbxUOH;
    private System.Windows.Forms.TextBox txtbxPrice;
  }
}