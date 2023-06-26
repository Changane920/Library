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

namespace Library.User_Control
{
    public partial class RentBook : UserControl
    {
        DataStore dataStore = new DataStore();
        public RentBook(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        public int bid { get; set; }
        public int uid { get; set; }

        private void RentBook_Load(object sender, EventArgs e)
        {
            //connection
            MySqlConnection cn = Dataconnection.connect();

            //get data from rentbook
            MySqlCommand cmd1 = new MySqlCommand("select * from rentbook", cn);

            MySqlDataReader reader = cmd1.ExecuteReader();


            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], Convert.ToDateTime(reader[2]).ToString("yyyy-MM-dd"), Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd"), reader[4], reader[5]);
            }
            reader.Close();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgv1.ClearSelection();

                    //get row when click cell
                    dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[1];
                    dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                    contextMenuStrip1.Show(MousePosition);

                    DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                    bid = int.Parse(row.Cells[0].Value.ToString());
                    uid = int.Parse(row.Cells[1].Value.ToString());
                }
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Error!", "Error Box", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    contextMenuStrip1.Visible = false;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            string sql = "delete from rentbook where bid = '" + bid + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cn);

            if (MessageBox.Show("Are you sure want to delete this?", "Delete Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Finish!", "Delete Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.Close();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime newTime = DateTime.Now;

            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand cmd = new MySqlCommand("update rentbook set actualReturnDate=@date where bid = @bid && uid = @uid", cn);
            cmd.Parameters.AddWithValue("@date", newTime.ToString("yyyy-MM-dd-h"));
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@uid", uid);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from rentbook";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], Convert.ToDateTime(reader[2]).ToString("yyyy-MM-dd"), Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd"), reader[4], reader[5]);
            }

            cn.Close();
        }
    }
}
