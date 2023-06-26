namespace Library.User
{
    partial class CartForm
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
            this.FlpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pboClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboClose)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpCart
            // 
            this.FlpCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpCart.Location = new System.Drawing.Point(0, 36);
            this.FlpCart.Name = "FlpCart";
            this.FlpCart.Size = new System.Drawing.Size(362, 447);
            this.FlpCart.TabIndex = 0;
            // 
            // pboClose
            // 
            this.pboClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboClose.Image = global::Library.Properties.Resources.close_icon_4;
            this.pboClose.Location = new System.Drawing.Point(334, 7);
            this.pboClose.Name = "pboClose";
            this.pboClose.Size = new System.Drawing.Size(20, 20);
            this.pboClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboClose.TabIndex = 1;
            this.pboClose.TabStop = false;
            this.pboClose.Click += new System.EventHandler(this.pboClose_Click);
            // 
            // CartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(362, 483);
            this.Controls.Add(this.pboClose);
            this.Controls.Add(this.FlpCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpCart;
        private System.Windows.Forms.PictureBox pboClose;
    }
}