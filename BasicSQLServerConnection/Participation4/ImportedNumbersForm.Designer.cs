namespace Participation4
{
  partial class ImportedNumbersForm
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
      this.components = new System.ComponentModel.Container();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnAvgAge = new System.Windows.Forms.Button();
      this.btnAgeOver30 = new System.Windows.Forms.Button();
      this.btnSortLast = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSerach = new System.Windows.Forms.Button();
      this.txtbxName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.uvuPhoneDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.uvuPhoneDirectoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.uVUPhoneNumsDataSet11 = new Participation4.UVUPhoneNumsDataSet1();
      this.uvuPhoneDirectoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.uvuPhoneDirectoryTableAdapter2 = new Participation4.UVUPhoneNumsDataSet1TableAdapters.UvuPhoneDirectoryTableAdapter();
      this.tableAdapterManager2 = new Participation4.UVUPhoneNumsDataSet1TableAdapters.TableAdapterManager();
      this.uvuPhoneDirectoryDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsDataSet11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(491, 391);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(181, 47);
      this.btnClear.TabIndex = 9;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnAvgAge
      // 
      this.btnAvgAge.Location = new System.Drawing.Point(304, 391);
      this.btnAvgAge.Name = "btnAvgAge";
      this.btnAvgAge.Size = new System.Drawing.Size(181, 47);
      this.btnAvgAge.TabIndex = 8;
      this.btnAvgAge.Text = "btnAvgAge";
      this.btnAvgAge.UseVisualStyleBackColor = true;
      this.btnAvgAge.Click += new System.EventHandler(this.btnAvgAge_Click);
      // 
      // btnAgeOver30
      // 
      this.btnAgeOver30.Location = new System.Drawing.Point(491, 338);
      this.btnAgeOver30.Name = "btnAgeOver30";
      this.btnAgeOver30.Size = new System.Drawing.Size(181, 47);
      this.btnAgeOver30.TabIndex = 7;
      this.btnAgeOver30.Text = "Age > 30";
      this.btnAgeOver30.UseVisualStyleBackColor = true;
      this.btnAgeOver30.Click += new System.EventHandler(this.btnAgeOver30_Click);
      // 
      // btnSortLast
      // 
      this.btnSortLast.Location = new System.Drawing.Point(304, 338);
      this.btnSortLast.Name = "btnSortLast";
      this.btnSortLast.Size = new System.Drawing.Size(181, 47);
      this.btnSortLast.TabIndex = 6;
      this.btnSortLast.Text = "Sort by Last Name";
      this.btnSortLast.UseVisualStyleBackColor = true;
      this.btnSortLast.Click += new System.EventHandler(this.btnSortLast_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnSerach);
      this.groupBox1.Controls.Add(this.txtbxName);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 338);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(277, 100);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Search";
      // 
      // btnSerach
      // 
      this.btnSerach.Location = new System.Drawing.Point(20, 53);
      this.btnSerach.Name = "btnSerach";
      this.btnSerach.Size = new System.Drawing.Size(197, 23);
      this.btnSerach.TabIndex = 2;
      this.btnSerach.Text = "Search";
      this.btnSerach.UseVisualStyleBackColor = true;
      this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
      // 
      // txtbxName
      // 
      this.txtbxName.Location = new System.Drawing.Point(59, 27);
      this.txtbxName.Name = "txtbxName";
      this.txtbxName.Size = new System.Drawing.Size(158, 20);
      this.txtbxName.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      // 
      // uvuPhoneDirectoryBindingSource
      // 
      this.uvuPhoneDirectoryBindingSource.DataMember = "UvuPhoneDirectory";
      // 
      // uvuPhoneDirectoryBindingSource1
      // 
      this.uvuPhoneDirectoryBindingSource1.DataMember = "UvuPhoneDirectory";
      // 
      // uVUPhoneNumsDataSet11
      // 
      this.uVUPhoneNumsDataSet11.DataSetName = "UVUPhoneNumsDataSet1";
      this.uVUPhoneNumsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // uvuPhoneDirectoryBindingSource2
      // 
      this.uvuPhoneDirectoryBindingSource2.DataMember = "UvuPhoneDirectory";
      this.uvuPhoneDirectoryBindingSource2.DataSource = this.uVUPhoneNumsDataSet11;
      // 
      // uvuPhoneDirectoryTableAdapter2
      // 
      this.uvuPhoneDirectoryTableAdapter2.ClearBeforeFill = true;
      // 
      // tableAdapterManager2
      // 
      this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager2.UpdateOrder = Participation4.UVUPhoneNumsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      this.tableAdapterManager2.UvuPhoneDirectoryTableAdapter = this.uvuPhoneDirectoryTableAdapter2;
      // 
      // uvuPhoneDirectoryDataGridView
      // 
      this.uvuPhoneDirectoryDataGridView.AutoGenerateColumns = false;
      this.uvuPhoneDirectoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.uvuPhoneDirectoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
      this.uvuPhoneDirectoryDataGridView.DataSource = this.uvuPhoneDirectoryBindingSource2;
      this.uvuPhoneDirectoryDataGridView.Location = new System.Drawing.Point(12, 12);
      this.uvuPhoneDirectoryDataGridView.Name = "uvuPhoneDirectoryDataGridView";
      this.uvuPhoneDirectoryDataGridView.Size = new System.Drawing.Size(602, 220);
      this.uvuPhoneDirectoryDataGridView.TabIndex = 9;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "UvuPhoneDirectoryId";
      this.dataGridViewTextBoxColumn1.HeaderText = "UvuPhoneDirectoryId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber";
      this.dataGridViewTextBoxColumn3.HeaderText = "PhoneNumber";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
      this.dataGridViewTextBoxColumn5.HeaderText = "Age";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // ImportedNumbersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(692, 458);
      this.Controls.Add(this.uvuPhoneDirectoryDataGridView);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnAvgAge);
      this.Controls.Add(this.btnAgeOver30);
      this.Controls.Add(this.btnSortLast);
      this.Controls.Add(this.groupBox1);
      this.Name = "ImportedNumbersForm";
      this.Text = "ImportedNumbersForm";
      this.Load += new System.EventHandler(this.ImportedNumbersForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsDataSet11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnAvgAge;
    private System.Windows.Forms.Button btnAgeOver30;
    private System.Windows.Forms.Button btnSortLast;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSerach;
    private System.Windows.Forms.TextBox txtbxName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource uvuPhoneDirectoryBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource uvuPhoneDirectoryBindingSource1;
    private UVUPhoneNumsDataSet1 uVUPhoneNumsDataSet11;
    private System.Windows.Forms.BindingSource uvuPhoneDirectoryBindingSource2;
    private UVUPhoneNumsDataSet1TableAdapters.UvuPhoneDirectoryTableAdapter uvuPhoneDirectoryTableAdapter2;
    private UVUPhoneNumsDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
    private System.Windows.Forms.DataGridView uvuPhoneDirectoryDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}