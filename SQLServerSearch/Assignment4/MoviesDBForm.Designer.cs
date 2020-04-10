namespace Assignment4
{
  partial class MoviesDBFOrm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtbxSearch = new System.Windows.Forms.TextBox();
      this.btnShowAll = new System.Windows.Forms.Button();
      this.btnCatCount = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.movieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.movieTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.moviesDataSet = new Assignment4.MoviesDataSet();
      this.movieTableAdapter = new Assignment4.MoviesDataSetTableAdapters.MovieTableAdapter();
      this.tableAdapterManager = new Assignment4.MoviesDataSetTableAdapters.TableAdapterManager();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtbxSearch);
      this.groupBox1.Location = new System.Drawing.Point(25, 304);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(343, 111);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Search Movie Title";
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(264, 68);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(73, 37);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtbxSearch
      // 
      this.txtbxSearch.Location = new System.Drawing.Point(6, 19);
      this.txtbxSearch.Name = "txtbxSearch";
      this.txtbxSearch.Size = new System.Drawing.Size(331, 20);
      this.txtbxSearch.TabIndex = 0;
      // 
      // btnShowAll
      // 
      this.btnShowAll.Location = new System.Drawing.Point(453, 372);
      this.btnShowAll.Name = "btnShowAll";
      this.btnShowAll.Size = new System.Drawing.Size(73, 38);
      this.btnShowAll.TabIndex = 1;
      this.btnShowAll.Text = "Show All Items";
      this.btnShowAll.UseVisualStyleBackColor = true;
      this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
      // 
      // btnCatCount
      // 
      this.btnCatCount.Location = new System.Drawing.Point(532, 371);
      this.btnCatCount.Name = "btnCatCount";
      this.btnCatCount.Size = new System.Drawing.Size(73, 38);
      this.btnCatCount.TabIndex = 2;
      this.btnCatCount.Text = "Bount By Category";
      this.btnCatCount.UseVisualStyleBackColor = true;
      this.btnCatCount.Click += new System.EventHandler(this.btnCatCount_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(611, 371);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(73, 38);
      this.btnExit.TabIndex = 3;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIdDataGridViewTextBoxColumn,
            this.movieTitleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.movieBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(25, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(659, 285);
      this.dataGridView1.TabIndex = 4;
      // 
      // movieIdDataGridViewTextBoxColumn
      // 
      this.movieIdDataGridViewTextBoxColumn.DataPropertyName = "MovieId";
      this.movieIdDataGridViewTextBoxColumn.HeaderText = "MovieId";
      this.movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
      this.movieIdDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // movieTitleDataGridViewTextBoxColumn
      // 
      this.movieTitleDataGridViewTextBoxColumn.DataPropertyName = "MovieTitle";
      this.movieTitleDataGridViewTextBoxColumn.HeaderText = "MovieTitle";
      this.movieTitleDataGridViewTextBoxColumn.Name = "movieTitleDataGridViewTextBoxColumn";
      // 
      // categoryDataGridViewTextBoxColumn
      // 
      this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
      this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
      this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
      // 
      // movieBindingSource
      // 
      this.movieBindingSource.DataMember = "Movie";
      this.movieBindingSource.DataSource = this.moviesDataSet;
      // 
      // moviesDataSet
      // 
      this.moviesDataSet.DataSetName = "MoviesDataSet";
      this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // movieTableAdapter
      // 
      this.movieTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
      this.tableAdapterManager.UpdateOrder = Assignment4.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // MoviesDBFOrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(696, 450);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnCatCount);
      this.Controls.Add(this.btnShowAll);
      this.Controls.Add(this.groupBox1);
      this.Name = "MoviesDBFOrm";
      this.Text = "MoviesDB";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtbxSearch;
    private System.Windows.Forms.Button btnShowAll;
    private System.Windows.Forms.Button btnCatCount;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.DataGridView dataGridView1;
    private MoviesDataSet moviesDataSet;
    private System.Windows.Forms.BindingSource movieBindingSource;
    private MoviesDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
    private MoviesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
  }
}

