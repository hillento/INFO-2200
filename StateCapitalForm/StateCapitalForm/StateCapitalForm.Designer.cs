namespace StateCapitalForm
{
  partial class StateCapitalForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtboxState = new System.Windows.Forms.TextBox();
      this.TxtboxCapital = new System.Windows.Forms.TextBox();
      this.BtnSubmit = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(53, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 24);
      this.label1.TabIndex = 5;
      this.label1.Text = "State";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(38, 104);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 24);
      this.label2.TabIndex = 4;
      this.label2.Text = "Capital";
      // 
      // TxtboxState
      // 
      this.TxtboxState.Location = new System.Drawing.Point(110, 75);
      this.TxtboxState.Name = "TxtboxState";
      this.TxtboxState.Size = new System.Drawing.Size(175, 20);
      this.TxtboxState.TabIndex = 1;
      // 
      // TxtboxCapital
      // 
      this.TxtboxCapital.Location = new System.Drawing.Point(110, 108);
      this.TxtboxCapital.Name = "TxtboxCapital";
      this.TxtboxCapital.Size = new System.Drawing.Size(175, 20);
      this.TxtboxCapital.TabIndex = 2;
      // 
      // BtnSubmit
      // 
      this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnSubmit.Location = new System.Drawing.Point(42, 146);
      this.BtnSubmit.Name = "BtnSubmit";
      this.BtnSubmit.Size = new System.Drawing.Size(243, 54);
      this.BtnSubmit.TabIndex = 3;
      this.BtnSubmit.Text = "Submit";
      this.BtnSubmit.UseVisualStyleBackColor = true;
      this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(319, 12);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(300, 224);
      this.listBox1.TabIndex = 5;
      // 
      // StateCapitalForm
      // 
      this.AcceptButton = this.BtnSubmit;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 277);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.BtnSubmit);
      this.Controls.Add(this.TxtboxCapital);
      this.Controls.Add(this.TxtboxState);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "StateCapitalForm";
      this.Load += new System.EventHandler(this.StateCapitalForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TxtboxState;
    private System.Windows.Forms.TextBox TxtboxCapital;
    private System.Windows.Forms.Button BtnSubmit;
    private System.Windows.Forms.ListBox listBox1;
  }
}

