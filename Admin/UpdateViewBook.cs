using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UpdateViewBook : Form
    {
        public int id { get; set; }
        public string bname { get; set; }
        public string authorName { get; set; }
        public string releaseYear { get; set; }
        public string genre { get; set; }

        public UpdateViewBook()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtBookName.Text = bname;
            txtAuthorName.Text = authorName;
            txtReleaseYear.Text = releaseYear;
            txtGenre.Text = genre;

            //get image from database
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand cmd = new MySqlCommand("select image from bookdetail where bid = '" + id + "'", cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //binary to image
                MemoryStream ms = new MemoryStream((byte[])reader["Image"]);
                pboUpdate.Image = new Bitmap(ms);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            string sql = "update BookDetail set b_Name = '" + txtBookName.Text + "',author_Name='" + txtAuthorName.Text + "',releaseYear='" + txtReleaseYear.Text + "',genre='" + txtGenre.Text + "'where bid='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);

            DialogResult dr = MessageBox.Show("Are you sure want to update this?", "Update Form", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                cmd.ExecuteReader();
                MessageBox.Show("Update Complete!", "Update Form", MessageBoxButtons.OK);
            }

            //connection close
            cn.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pboUpdate.Image = img;
            }
        }
    }
}
