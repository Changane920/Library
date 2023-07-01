using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class CartUserControl : UserControl
    {
        DataStore dataStore = new DataStore();
        public CartUserControl(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }

        private Image img;
        private string title;
        private string productDetail;

        public Image Img
        {
            get { return img; }
            set { img = value; pboList.Image = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }
        }
        public string ProductDetail
        {
            get { return productDetail; }
            set { productDetail = value; lblProductDetail.Text = value; }
        }

        private void pboDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();
            MySqlCommand query = new MySqlCommand("delete from buyerhistory where bid in(select bid from bookdetail where b_name=@bookName && uid = @uid)",cn);
            query.Parameters.AddWithValue("@bookName", title);
            query.Parameters.AddWithValue("@uid", dataStore.uid);

            if(MessageBox.Show("Are you sure?","Delete Form",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Success!");
            } 
            else
            {
                MessageBox.Show("Fail!");
            }
            cn.Close();            
        }

        private void CartUserControl_Load(object sender, EventArgs e)
        {
        }
    }
}
