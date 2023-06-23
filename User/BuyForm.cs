using Library.DynamicUserControl;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class BuyForm : Form
    {
        DataStore dataStore = new DataStore();
        public BuyForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            //get data from bookdetail
            MySqlCommand cmd = new MySqlCommand("select*from bookdetail where bid = @bid", cn);

            //value assign to cmd
            cmd.Parameters.AddWithValue("@bid", dataStore.bid);

            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                //binary to image
                MemoryStream ms = new MemoryStream((byte[])reader["Image"]);
                pictureBox1.Image = new Bitmap(ms);

                //data from database to label
                lblShowTitle.Text = reader["b_name"].ToString();
                lblShowAuthorName.Text = reader["author_Name"].ToString();
                lblShowGenre.Text = reader["genre"].ToString();
                lblShowReleaseYear.Text = reader["releaseYear"].ToString();
                lblShowPrice.Text = "500";
            }
            reader.Close();
            cn.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Library", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    txtQuantity.Text = "1";
                }

                //connection
                MySqlConnection cn = Dataconnection.connect();

                //add data into buyerhistory
                MySqlCommand cmd = new MySqlCommand("insert into buyerhistory values (@bid,@uid,@price,@quantity,@boughDate)", cn);

                //value assign to cmd
                cmd.Parameters.AddWithValue("@bid", dataStore.bid);
                cmd.Parameters.AddWithValue("@uid", dataStore.uid);
                cmd.Parameters.AddWithValue("@price", lblShowPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

                DateTime currentDate = DateTime.Now;
                cmd.Parameters.AddWithValue("@boughDate", currentDate.ToString("yyyy-MM-dd"));

                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    MessageBox.Show("Thank You!", "Library", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fail!", "Library", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            int result = 0;
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    txtQuantity.Text = "1";
                }

                int num = int.Parse(lblShowPrice.Text);
                int limit = int.Parse(txtQuantity.Text);

                for(int i = 0; i < limit; i++)
                {
                    result += num;
                    lblShowPrice.Text = result.ToString();
                }
            }
            else if(e.KeyChar == (char)Keys.Back)
            {
                lblShowPrice.Text = "500";
            }
        }
    }
}
