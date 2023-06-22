namespace Library.User_Control
{
    partial class BookDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dv_Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_BName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 516);
            this.panel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(5, 149);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(5, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(5, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 42);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCC
            // 
            this.btnCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCC.ForeColor = System.Drawing.Color.Black;
            this.btnCC.Location = new System.Drawing.Point(5, 5);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(141, 42);
            this.btnCC.TabIndex = 2;
            this.btnCC.Text = "Check Connection";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeight = 30;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv_Bid,
            this.dv_BName,
            this.dv_Author,
            this.dv_ReleaseYear,
            this.dv_Genre,
            this.dv_BorrowDate,
            this.dv_ReturnDate,
            this.dv_Issue});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv1.Location = new System.Drawing.Point(152, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv1.Size = new System.Drawing.Size(1133, 516);
            this.dgv1.TabIndex = 6;
            // 
            // dv_Bid
            // 
            this.dv_Bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Bid.HeaderText = "Book_ID";
            this.dv_Bid.MinimumWidth = 6;
            this.dv_Bid.Name = "dv_Bid";
            this.dv_Bid.ReadOnly = true;
            // 
            // dv_BName
            // 
            this.dv_BName.HeaderText = "Book_Name";
            this.dv_BName.MinimumWidth = 6;
            this.dv_BName.Name = "dv_BName";
            this.dv_BName.ReadOnly = true;
            this.dv_BName.Width = 125;
            // 
            // dv_Author
            // 
            this.dv_Author.HeaderText = "Author";
            this.dv_Author.MinimumWidth = 6;
            this.dv_Author.Name = "dv_Author";
            this.dv_Author.ReadOnly = true;
            this.dv_Author.Width = 125;
            // 
            // dv_ReleaseYear
            // 
            this.dv_ReleaseYear.HeaderText = "Release Year";
            this.dv_ReleaseYear.MinimumWidth = 6;
            this.dv_ReleaseYear.Name = "dv_ReleaseYear";
            this.dv_ReleaseYear.ReadOnly = true;
            this.dv_ReleaseYear.Width = 125;
            // 
            // dv_Genre
            // 
            this.dv_Genre.HeaderText = "Genre";
            this.dv_Genre.MinimumWidth = 6;
            this.dv_Genre.Name = "dv_Genre";
            this.dv_Genre.ReadOnly = true;
            this.dv_Genre.Width = 125;
            // 
            // dv_BorrowDate
            // 
            this.dv_BorrowDate.HeaderText = "Borrow Date";
            this.dv_BorrowDate.MinimumWidth = 6;
            this.dv_BorrowDate.Name = "dv_BorrowDate";
            this.dv_BorrowDate.ReadOnly = true;
            this.dv_BorrowDate.Width = 125;
            // 
            // dv_ReturnDate
            // 
            this.dv_ReturnDate.HeaderText = "Return Date";
            this.dv_ReturnDate.MinimumWidth = 6;
            this.dv_ReturnDate.Name = "dv_ReturnDate";
            this.dv_ReturnDate.ReadOnly = true;
            this.dv_ReturnDate.Width = 125;
            // 
            // dv_Issue
            // 
            this.dv_Issue.HeaderText = "Issue Book";
            this.dv_Issue.MinimumWidth = 6;
            this.dv_Issue.Name = "dv_Issue";
            this.dv_Issue.ReadOnly = true;
            this.dv_Issue.Width = 200;
            // 
            // BookDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Name = "BookDetail";
            this.Size = new System.Drawing.Size(1285, 516);
            this.Load += new System.EventHandler(this.BookDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_BName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Issue;
    }
}
