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

        private void RentBook_Load(object sender, EventArgs e)
        {
            //connection
            MySqlConnection cn = Dataconnection.connect();

            //get data from rentbook
            MySqlCommand cmd1 = new MySqlCommand("select * from rentbook", cn);

            MySqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], Convert.ToDateTime(reader[2]).ToString("yyyy-MM-dd"), Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd"), Convert.ToDateTime(reader[4]).ToString("yyyy-MM-dd"), reader[5]);
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

                    //get data when click cell
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
