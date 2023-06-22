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
    public partial class BookDetail : UserControl
    {
        public BookDetail()
        {
            InitializeComponent();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            string cnStr = "server = localhost; uid = root; pwd = root; database = library";
            MySqlConnection cn = new MySqlConnection(cnStr);
            cn.Open();
            try
            {
                DialogResult response = MessageBox.Show("Connection success!", "Book Detail", MessageBoxButtons.OK);

                if (response == DialogResult.OK)
                {
                    dgv1.Visible = true;
                    dgv1.Rows.Clear();
                    string sql = "select * from BookDetail";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "People", MessageBoxButtons.OK);
            }
            cn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            string cnStr = "server=localhost; uid=root; pwd=root; database=library";
            MySqlConnection cn = new MySqlConnection(cnStr);
            cn.Open();

            string sql = "select * from BookDetail";
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgv1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], Convert.ToDateTime(reader[5]).ToString("dd-MM-yyyy"), Convert.ToDateTime(reader[6]).ToString("dd-MM-yyyy"), reader[7]);
            }
            cn.Close();
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            dgv1.Visible = false;
        }
    }
}
