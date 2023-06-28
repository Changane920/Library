using Library.DynamicUserControl;
using MySql.Data.MySqlClient;
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

namespace Library.User
{
    public partial class CartForm : Form
    {
        DataStore dataStore = new DataStore();
        public CartForm(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        public DataTable readItem()
        {
            MySqlConnection cn = Dataconnection.connect();
            string query = "select bid,image,b_name,price from bookdetail b where bid in(select bid from buyerhistory where uid = @uid);";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@uid", dataStore.uid);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                lblPrice.Text = reader["price"].ToString();

                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                return dt;
            }
            catch { throw; }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            CartUserControl();
        }

        private void CartUserControl()
        {
            FlpCart.Controls.Clear();
            DataTable dt = readItem();
            
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    CartUserControl[] ArrayItems = new CartUserControl[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            ArrayItems[i] = new CartUserControl(dataStore);
                            //binary to img
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            ArrayItems[i].Img = new Bitmap(ms);
                            ArrayItems[i].Title = row["b_name"].ToString();

                            FlpCart.Controls.Add(ArrayItems[i]);
                        }
                    }
                }
            }
        }

        private void pboClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
