namespace Library.User_Control
{
    partial class RentBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dv_bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_ActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 516);
            this.panel2.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(5, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeight = 30;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv_bid,
            this.dv_UserId,
            this.dv_RentDate,
            this.dv_ReturnDate,
            this.dv_ActualReturnDate,
            this.dv_Issue});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv1.Location = new System.Drawing.Point(152, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1133, 516);
            this.dgv1.TabIndex = 6;
            this.dgv1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // dv_bid
            // 
            this.dv_bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dv_bid.FillWeight = 40F;
            this.dv_bid.HeaderText = "Book Id";
            this.dv_bid.MinimumWidth = 6;
            this.dv_bid.Name = "dv_bid";
            this.dv_bid.Width = 82;
            // 
            // dv_UserId
            // 
            this.dv_UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dv_UserId.FillWeight = 16.04278F;
            this.dv_UserId.HeaderText = "User Id";
            this.dv_UserId.MinimumWidth = 6;
            this.dv_UserId.Name = "dv_UserId";
            this.dv_UserId.Width = 79;
            // 
            // dv_RentDate
            // 
            this.dv_RentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dv_RentDate.FillWeight = 16.04278F;
            this.dv_RentDate.HeaderText = "Rent Date";
            this.dv_RentDate.MinimumWidth = 6;
            this.dv_RentDate.Name = "dv_RentDate";
            this.dv_RentDate.Width = 96;
            // 
            // dv_ReturnDate
            // 
            this.dv_ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dv_ReturnDate.FillWeight = 16.04278F;
            this.dv_ReturnDate.HeaderText = "Expected Return Date";
            this.dv_ReturnDate.MinimumWidth = 6;
            this.dv_ReturnDate.Name = "dv_ReturnDate";
            this.dv_ReturnDate.Width = 167;
            // 
            // dv_ActualReturnDate
            // 
            this.dv_ActualReturnDate.HeaderText = "Actual Return Date";
            this.dv_ActualReturnDate.MinimumWidth = 6;
            this.dv_ActualReturnDate.Name = "dv_ActualReturnDate";
            this.dv_ActualReturnDate.Width = 125;
            // 
            // dv_Issue
            // 
            this.dv_Issue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dv_Issue.FillWeight = 200F;
            this.dv_Issue.HeaderText = "Issue";
            this.dv_Issue.MinimumWidth = 6;
            this.dv_Issue.Name = "dv_Issue";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.closeToolStripMenuItem.Text = "Delete";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // RentBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv1);
            this.Name = "RentBook";
            this.Size = new System.Drawing.Size(1285, 516);
            this.Load += new System.EventHandler(this.RentBook_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_ActualReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_Issue;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
    }
}
