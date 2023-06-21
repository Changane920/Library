namespace LibraryPJ
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.lblBookList = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAddBookList = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBID = new System.Windows.Forms.Label();
            this.lblBTitle = new System.Windows.Forms.Label();
            this.lblBAuthor = new System.Windows.Forms.Label();
            this.lblBQuantity = new System.Windows.Forms.Label();
            this.lblBPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLibrary
            // 
            this.lblLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrary.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblLibrary.Location = new System.Drawing.Point(367, 1);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(112, 34);
            this.lblLibrary.TabIndex = 1;
            this.lblLibrary.Text = "Library";
            this.lblLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookList
            // 
            this.lblBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookList.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblBookList.Location = new System.Drawing.Point(367, 294);
            this.lblBookList.Name = "lblBookList";
            this.lblBookList.Size = new System.Drawing.Size(112, 34);
            this.lblBookList.TabIndex = 2;
            this.lblBookList.Text = "Book Lists";
            this.lblBookList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(44, 82);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(149, 31);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "Book Name";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(432, 82);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(149, 31);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(44, 161);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(149, 31);
            this.lblStudentName.TabIndex = 5;
            this.lblStudentName.Text = "Student Name";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(432, 161);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(149, 31);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price $";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(199, 82);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 31);
            this.txtBookName.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(199, 161);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(207, 31);
            this.txtStudentName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(587, 82);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(207, 31);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(587, 163);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(207, 31);
            this.txtPrice.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(48, 1);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(108, 34);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBookList
            // 
            this.btnAddBookList.BackColor = System.Drawing.Color.Lime;
            this.btnAddBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookList.Location = new System.Drawing.Point(199, 238);
            this.btnAddBookList.Name = "btnAddBookList";
            this.btnAddBookList.Size = new System.Drawing.Size(207, 31);
            this.btnAddBookList.TabIndex = 12;
            this.btnAddBookList.Text = "Add to Book Lists";
            this.btnAddBookList.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lime;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(469, 238);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 31);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Lime;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(682, 238);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(112, 31);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblBPrice, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBQuantity, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBAuthor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(199, 350);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 115);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // lblBID
            // 
            this.lblBID.BackColor = System.Drawing.Color.Silver;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(3, 0);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(94, 23);
            this.lblBID.TabIndex = 17;
            this.lblBID.Text = "BID";
            this.lblBID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBTitle
            // 
            this.lblBTitle.BackColor = System.Drawing.Color.Silver;
            this.lblBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTitle.Location = new System.Drawing.Point(103, 0);
            this.lblBTitle.Name = "lblBTitle";
            this.lblBTitle.Size = new System.Drawing.Size(94, 23);
            this.lblBTitle.TabIndex = 18;
            this.lblBTitle.Text = "BTitle";
            this.lblBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBAuthor
            // 
            this.lblBAuthor.BackColor = System.Drawing.Color.Silver;
            this.lblBAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAuthor.Location = new System.Drawing.Point(203, 0);
            this.lblBAuthor.Name = "lblBAuthor";
            this.lblBAuthor.Size = new System.Drawing.Size(94, 23);
            this.lblBAuthor.TabIndex = 19;
            this.lblBAuthor.Text = "BAuthor";
            this.lblBAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBQuantity
            // 
            this.lblBQuantity.BackColor = System.Drawing.Color.Silver;
            this.lblBQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBQuantity.Location = new System.Drawing.Point(303, 0);
            this.lblBQuantity.Name = "lblBQuantity";
            this.lblBQuantity.Size = new System.Drawing.Size(94, 23);
            this.lblBQuantity.TabIndex = 20;
            this.lblBQuantity.Text = "BQuantity";
            this.lblBQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBPrice
            // 
            this.lblBPrice.BackColor = System.Drawing.Color.Silver;
            this.lblBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPrice.Location = new System.Drawing.Point(403, 0);
            this.lblBPrice.Name = "lblBPrice";
            this.lblBPrice.Size = new System.Drawing.Size(94, 23);
            this.lblBPrice.TabIndex = 21;
            this.lblBPrice.Text = "BPrice";
            this.lblBPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(862, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddBookList);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookList);
            this.Controls.Add(this.lblLibrary);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.Label lblBookList;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAddBookList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBPrice;
        private System.Windows.Forms.Label lblBQuantity;
        private System.Windows.Forms.Label lblBAuthor;
        private System.Windows.Forms.Label lblBTitle;
        private System.Windows.Forms.Label lblBID;
    }
}