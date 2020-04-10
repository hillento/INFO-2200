namespace Participation4
{
  partial class LandingForm
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
      this.btnLocalNumbers = new System.Windows.Forms.Button();
      this.btnImportedNums = new System.Windows.Forms.Button();
      this.btnOnlineNums = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnLocalNumbers
      // 
      this.btnLocalNumbers.Location = new System.Drawing.Point(12, 12);
      this.btnLocalNumbers.Name = "btnLocalNumbers";
      this.btnLocalNumbers.Size = new System.Drawing.Size(160, 84);
      this.btnLocalNumbers.TabIndex = 0;
      this.btnLocalNumbers.Text = "Local Phone Numbers";
      this.btnLocalNumbers.UseVisualStyleBackColor = true;
      this.btnLocalNumbers.Click += new System.EventHandler(this.btnLocalNumbers_Click);
      // 
      // btnImportedNums
      // 
      this.btnImportedNums.Location = new System.Drawing.Point(178, 12);
      this.btnImportedNums.Name = "btnImportedNums";
      this.btnImportedNums.Size = new System.Drawing.Size(160, 84);
      this.btnImportedNums.TabIndex = 1;
      this.btnImportedNums.Text = "Imported Phone Numbers";
      this.btnImportedNums.UseVisualStyleBackColor = true;
      this.btnImportedNums.Click += new System.EventHandler(this.btnImportedNums_Click);
      // 
      // btnOnlineNums
      // 
      this.btnOnlineNums.Location = new System.Drawing.Point(12, 101);
      this.btnOnlineNums.Name = "btnOnlineNums";
      this.btnOnlineNums.Size = new System.Drawing.Size(160, 84);
      this.btnOnlineNums.TabIndex = 2;
      this.btnOnlineNums.Text = "Online Numbers";
      this.btnOnlineNums.UseVisualStyleBackColor = true;
      this.btnOnlineNums.Click += new System.EventHandler(this.btnOnlineNums_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(178, 101);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(160, 84);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // LandingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 210);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnOnlineNums);
      this.Controls.Add(this.btnImportedNums);
      this.Controls.Add(this.btnLocalNumbers);
      this.Name = "LandingForm";
      this.Text = "LandingForm";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLocalNumbers;
    private System.Windows.Forms.Button btnImportedNums;
    private System.Windows.Forms.Button btnOnlineNums;
    private System.Windows.Forms.Button btnClose;
  }
}