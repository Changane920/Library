using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UpdateForm : Form
    {
        public int id { get; set; }
        public string bname { get; set; }
        public string authorName { get; set; }
        public string releaseYear { get; set; }
        public string genre { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtBookName.Text = bname;
            txtAuthorName.Text = authorName;
            txtReleaseYear.Text = releaseYear;
            txtGenre.Text = genre;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cnStr = "server = localhost; uid = root; pwd = root; database = library";
            MySqlConnection cn = new MySqlConnection(cnStr);
            cn.Open();

            string sql = "update BookDetail set bname = '" + txtBookName.Text + "',author_Name='" + txtAuthorName.Text + "',releaseYear='" + txtReleaseYear.Text + "',genre='" + txtGenre.Text + "'where bid='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            DialogResult dr = MessageBox.Show("Are you sure want to update this?", "Update Form", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                cmd.ExecuteReader();
                MessageBox.Show("Update Complete!", "Update Form", MessageBoxButtons.OK);
                Close();
            }
            cn.Close();
        }
    }
}
