namespace Participation4
{
  partial class OnlineNumbersForm
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
      this.localPhoneListDBDataSet = new Participation4.LocalPhoneListDBDataSet();
      this.localPhonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.localPhonesTableAdapter = new Participation4.LocalPhoneListDBDataSetTableAdapters.LocalPhonesTableAdapter();
      this.tableAdapterManager = new Participation4.LocalPhoneListDBDataSetTableAdapters.TableAdapterManager();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.phoneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.inStateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.phoneListDbDataSet = new Participation4.PhoneListDbDataSet();
      this.phoneTableAdapter = new Participation4.PhoneListDbDataSetTableAdapters.PhoneTableAdapter();
      this.tableAdapterManager1 = new Participation4.PhoneListDbDataSetTableAdapters.TableAdapterManager();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDBDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhonesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListDbDataSet)).BeginInit();
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
      // localPhoneListDBDataSet
      // 
      this.localPhoneListDBDataSet.DataSetName = "LocalPhoneListDBDataSet";
      this.localPhoneListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // localPhonesBindingSource
      // 
      this.localPhonesBindingSource.DataMember = "LocalPhones";
      this.localPhonesBindingSource.DataSource = this.localPhoneListDBDataSet;
      // 
      // localPhonesTableAdapter
      // 
      this.localPhonesTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.LocalPhonesTableAdapter = this.localPhonesTableAdapter;
      this.tableAdapterManager.UpdateOrder = Participation4.LocalPhoneListDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.inStateDataGridViewCheckBoxColumn,
            this.ageDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.phoneBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(676, 227);
      this.dataGridView1.TabIndex = 10;
      // 
      // phoneIdDataGridViewTextBoxColumn
      // 
      this.phoneIdDataGridViewTextBoxColumn.DataPropertyName = "PhoneId";
      this.phoneIdDataGridViewTextBoxColumn.HeaderText = "PhoneId";
      this.phoneIdDataGridViewTextBoxColumn.Name = "phoneIdDataGridViewTextBoxColumn";
      this.phoneIdDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      // 
      // phoneNumberDataGridViewTextBoxColumn
      // 
      this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
      this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
      this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
      // 
      // inStateDataGridViewCheckBoxColumn
      // 
      this.inStateDataGridViewCheckBoxColumn.DataPropertyName = "InState";
      this.inStateDataGridViewCheckBoxColumn.HeaderText = "InState";
      this.inStateDataGridViewCheckBoxColumn.Name = "inStateDataGridViewCheckBoxColumn";
      // 
      // ageDataGridViewTextBoxColumn
      // 
      this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
      this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
      this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
      // 
      // phoneBindingSource
      // 
      this.phoneBindingSource.DataMember = "Phone";
      this.phoneBindingSource.DataSource = this.phoneListDbDataSet;
      // 
      // phoneListDbDataSet
      // 
      this.phoneListDbDataSet.DataSetName = "PhoneListDbDataSet";
      this.phoneListDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // phoneTableAdapter
      // 
      this.phoneTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager1
      // 
      this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager1.PhoneTableAdapter = this.phoneTableAdapter;
      this.tableAdapterManager1.UpdateOrder = Participation4.PhoneListDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // OnlineNumbersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 450);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnAvgAge);
      this.Controls.Add(this.btnAgeOver30);
      this.Controls.Add(this.btnSortLast);
      this.Controls.Add(this.groupBox1);
      this.Name = "OnlineNumbersForm";
      this.Text = "OnlineNumbersForm";
      this.Load += new System.EventHandler(this.OnlineNumbersForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDBDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhonesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListDbDataSet)).EndInit();
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
    private LocalPhoneListDBDataSet localPhoneListDBDataSet;
    private System.Windows.Forms.BindingSource localPhonesBindingSource;
    private LocalPhoneListDBDataSetTableAdapters.LocalPhonesTableAdapter localPhonesTableAdapter;
    private LocalPhoneListDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridView dataGridView1;
    private PhoneListDbDataSet phoneListDbDataSet;
    private System.Windows.Forms.BindingSource phoneBindingSource;
    private PhoneListDbDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
    private PhoneListDbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    private System.Windows.Forms.DataGridViewTextBoxColumn phoneIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn inStateDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
  }
}