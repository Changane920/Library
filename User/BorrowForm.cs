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

namespace Library.User
{
    public partial class BorrowForm : Form
    {
        //get uid and bid
        DataStore dataStore = new DataStore();
        public BorrowForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            //isnert into rentbook db
            MySqlCommand cmd = new MySqlCommand("insert into rentbook(rentDate, returnDate, issue) values (@rentDate,@reutnrDate,@issue) ",cn);

            //select image from bookdetail db
            MySqlCommand selectCmd = new MySqlCommand("select image from bookdetail where bid = @bid", cn);

            //cmd assign value
            cmd.Parameters.AddWithValue("@rentDate",dtpBorrow.Text);
            cmd.Parameters.AddWithValue("@returnDate",dtpReturn.Text);
            cmd.Parameters.AddWithValue("@issue", txtIssue.Text);

            //selectCmd value assign
            selectCmd.Parameters.AddWithValue("@bid", dataStore.bid);

            MySqlDataReader reader = selectCmd.ExecuteReader();

            if (Convert.ToBoolean(cmd.ExecuteNonQuery()) && reader.Read())
            {
                MessageBox.Show("Borrorw Success!", "Borrow Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } 
            else
            {
                MessageBox.Show("Borrorw Fail!", "Borrow Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            cn.Close();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
