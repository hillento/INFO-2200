namespace Assignment1
{
  partial class Form1
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
      this.TxtAnswer = new System.Windows.Forms.TextBox();
      this.BtnSubmitResponse = new System.Windows.Forms.Button();
      this.ListBoxAnswers = new System.Windows.Forms.ListBox();
      this.BtnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(229, 37);
      this.label1.TabIndex = 4;
      this.label1.Text = "8 Ball Answers";
      // 
      // TxtAnswer
      // 
      this.TxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtAnswer.Location = new System.Drawing.Point(19, 49);
      this.TxtAnswer.Name = "TxtAnswer";
      this.TxtAnswer.Size = new System.Drawing.Size(379, 26);
      this.TxtAnswer.TabIndex = 5;
      // 
      // BtnSubmitResponse
      // 
      this.BtnSubmitResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnSubmitResponse.Location = new System.Drawing.Point(19, 81);
      this.BtnSubmitResponse.Name = "BtnSubmitResponse";
      this.BtnSubmitResponse.Size = new System.Drawing.Size(379, 83);
      this.BtnSubmitResponse.TabIndex = 6;
      this.BtnSubmitResponse.Text = "Submit";
      this.BtnSubmitResponse.UseVisualStyleBackColor = true;
      this.BtnSubmitResponse.Click += new System.EventHandler(this.BtnSubmitResponse_Click);
      // 
      // ListBoxAnswers
      // 
      this.ListBoxAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ListBoxAnswers.FormattingEnabled = true;
      this.ListBoxAnswers.ItemHeight = 25;
      this.ListBoxAnswers.Location = new System.Drawing.Point(410, 12);
      this.ListBoxAnswers.Name = "ListBoxAnswers";
      this.ListBoxAnswers.Size = new System.Drawing.Size(378, 254);
      this.ListBoxAnswers.TabIndex = 7;
      // 
      // BtnExit
      // 
      this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnExit.Location = new System.Drawing.Point(410, 288);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(378, 83);
      this.BtnExit.TabIndex = 8;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnExit);
      this.Controls.Add(this.ListBoxAnswers);
      this.Controls.Add(this.BtnSubmitResponse);
      this.Controls.Add(this.TxtAnswer);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtAnswer;
    private System.Windows.Forms.Button BtnSubmitResponse;
    private System.Windows.Forms.ListBox ListBoxAnswers;
    private System.Windows.Forms.Button BtnExit;
  }
}

