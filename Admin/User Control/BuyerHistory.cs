using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.User_Control
{
    public partial class BuyerHistory : UserControl
    {
        //declare variable
        ViewBook vb = new ViewBook();
        private DataStore dataStore = new DataStore();

        public BuyerHistory(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            MySqlConnection cn = Dataconnection.connect();

            string sql = "select * from buyerhistory";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
            }
            cn.Close();
        }

        private void OrderedBook_Load(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            //connection open
            MySqlConnection cn = Dataconnection.connect();

            try
            {
                DialogResult response = MessageBox.Show("Connection success!", "Book Detail", MessageBoxButtons.OK);

                if (response == DialogResult.OK)
                {
                    dgv1.Visible = true;
                    dgv1.Rows.Clear();

                    string sql = "select * from buyerhistory;";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //insert into datagridview
                    while (reader.Read())
                    {
                        dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "People", MessageBoxButtons.OK);
            }
            //connectoin close
            cn.Close();
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgv1.ClearSelection();

                    //get row
                    dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[1];
                    dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                    contextMenuStrip1.Show(MousePosition);

                    DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
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
    }
}
