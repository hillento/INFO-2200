namespace Assignment4
{
  partial class CatCountForm
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.movieCatCount = new Assignment4.MovieCatCount();
      this.movieCategorySummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.movieCategorySummaryTableAdapter = new Assignment4.MovieCatCountTableAdapters.MovieCategorySummaryTableAdapter();
      this.tableAdapterManager = new Assignment4.MovieCatCountTableAdapters.TableAdapterManager();
      this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnCatClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.movieCatCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.movieCategorySummaryBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.movieCategorySummaryBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(24, 23);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(388, 221);
      this.dataGridView1.TabIndex = 0;
      // 
      // movieCatCount
      // 
      this.movieCatCount.DataSetName = "MovieCatCount";
      this.movieCatCount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // movieCategorySummaryBindingSource
      // 
      this.movieCategorySummaryBindingSource.DataMember = "MovieCategorySummary";
      this.movieCategorySummaryBindingSource.DataSource = this.movieCatCount;
      // 
      // movieCategorySummaryTableAdapter
      // 
      this.movieCategorySummaryTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.Connection = null;
      this.tableAdapterManager.UpdateOrder = Assignment4.MovieCatCountTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // categoryDataGridViewTextBoxColumn
      // 
      this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
      this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
      this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
      // 
      // countDataGridViewTextBoxColumn
      // 
      this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
      this.countDataGridViewTextBoxColumn.HeaderText = "Count";
      this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
      this.countDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // btnCatClose
      // 
      this.btnCatClose.Location = new System.Drawing.Point(279, 260);
      this.btnCatClose.Name = "btnCatClose";
      this.btnCatClose.Size = new System.Drawing.Size(132, 42);
      this.btnCatClose.TabIndex = 1;
      this.btnCatClose.Text = "Close";
      this.btnCatClose.UseVisualStyleBackColor = true;
      this.btnCatClose.Click += new System.EventHandler(this.btnCatClose_Click);
      // 
      // CatCountForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(440, 318);
      this.Controls.Add(this.btnCatClose);
      this.Controls.Add(this.dataGridView1);
      this.Name = "CatCountForm";
      this.Text = "CatCountForm";
      this.Load += new System.EventHandler(this.CatCountForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.movieCatCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.movieCategorySummaryBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private MovieCatCount movieCatCount;
    private System.Windows.Forms.BindingSource movieCategorySummaryBindingSource;
    private MovieCatCountTableAdapters.MovieCategorySummaryTableAdapter movieCategorySummaryTableAdapter;
    private MovieCatCountTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnCatClose;
  }
}