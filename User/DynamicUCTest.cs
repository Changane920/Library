using Library.DynamicUserControl;
using Library.User;
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

//need to add function list
//logout
//add to cart
//username at corner

//to make borrow form 
//BookName
//RentDate
//ExceptReturnDate
//Pirce (or not)

//need to do
//borrow form Db
//buyerhistory same name validation
//add price and quantity to bookdetail db

namespace Library
{
    public partial class DynamicUCTest : Form
    {
        //data call from datastore
        DataStore dataStore = new DataStore();
        public DynamicUCTest(DataStore data)
        {
            InitializeComponent();
            dataStore = data;
        }
        //to call multiple reader
        MySqlDataReader reader = null;

        //add item to table
        public bool AddItemsToTable(Image img, string bookName, string authorName, string genre, int releaseYear)
        {
            MySqlConnection cn = Dataconnection.connect();
            string sql = "Insert into bookdetail(image,b_name,author_Name,genre,releaseYear) values (@img,@bookName,@authorName,@genre,@releaseYear)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@bookName", bookName.Trim());
                cmd.Parameters.AddWithValue("@authorName", authorName.Trim());
                cmd.Parameters.AddWithValue("@genre", genre.Trim());
                cmd.Parameters.AddWithValue("@releaseYear", releaseYear);

                //convert image to binary format
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                cmd.Parameters.AddWithValue("@img", ms.ToArray());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                throw;
            }
            cn.Close();
        }

        //read items from table
        public DataTable ReadItemsTable()
        {
            MySqlConnection cn = Dataconnection.connect();
            string query = "select * from bookdetail";
            MySqlCommand cmd = new MySqlCommand(query, cn);
            try
            {
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mda.Fill(dt);
                return dt;
            }
            catch { throw; }
        }

        private void GenerateUserControl()
        {
            flowLayoutPanel1.Controls.Clear();
            Function function = new Function();
            DataTable dt = function.GetItems();

            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    UserControl1[] ArrayItems = new UserControl1[dt.Rows.Count];
                    for(int i = 0; i < 1; i++)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            ArrayItems[i] = new UserControl1();
                            //binary to img
                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            ArrayItems[i].Icon = new Bitmap(ms);
                            ArrayItems[i].BookName = row["b_name"].ToString();
                            ArrayItems[i].AuthorName = row["author_name"].ToString();
                            ArrayItems[i].Genre = row["genre"].ToString();
                            ArrayItems[i].ReleaseYear = int.Parse(row["releaseYear"].ToString());

                            flowLayoutPanel1.Controls.Add(ArrayItems[i]);
                            ArrayItems[i].Click += new System.EventHandler(this.UserControl_Click);
                        }
                    }
                }
            }
        }

        //click event from usercontrol1
        void UserControl_Click(object sender, System.EventArgs e)
        {
            //user control object to acess controls used in it 
            UserControl1 uc = (UserControl1)sender;
            pictureBox1.Image = uc.Icon;
            lblTitle.Text = uc.BookName;
            lblAName.Text = uc.AuthorName;
            lblGenre2.Text = uc.Genre;
            lblRYear.Text = uc.ReleaseYear.ToString();
            ShowPanel();
        }

        private void ShowPanel()
        {
            panel1.Visible = true;
            detailPanel.Visible = true;
        }
        private void hidepanel()
        {
            panel1.Visible = false;
            detailPanel.Visible = false;
        }

        private void DynamicUCTest_Load(object sender, EventArgs e)
        {
            GenerateUserControl();
            detailPanel.Visible = false;
        }

        public void getBookID()
        {
            MySqlConnection cn = Dataconnection.connect();

            MySqlCommand cmd = new MySqlCommand("select bid from bookdetail where b_name='" + lblTitle.Text + "'", cn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dataStore.bid = int.Parse(reader["bid"].ToString());
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            getBookID();
            BorrowForm borrorwForm = new BorrowForm(dataStore);
            borrorwForm.ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            getBookID();
            BuyForm buyForm = new BuyForm(dataStore);
            buyForm.ShowDialog();

        }
    }
}
