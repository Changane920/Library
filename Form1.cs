using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.User_Control;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    public partial class Form1 : Form
    {
        private DataStore dataStore = new DataStore();

        public Form1(DataStore data)
        {
            InitializeComponent();
            signuppanel.Visible = false;
            dataStore = data;
        }

        int count, attempt;
        MySqlDataReader reader = null;

        void disable()
        {
            if (attempt == 3)
            {
                MessageBox.Show("you have made too many attempts! \nPlease try again.", "Attempts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                attempt = 0;

                count = 10;

                loginTimer.Enabled = true;
                btnLogin.Enabled = false;
                txtLoginPass.Enabled = false;
                txtLoginUserName.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text == "Username")
            {
                txtLoginUserName.Clear();
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLoginUserName.Text == "Username")
            {
                txtLoginUserName.Clear();
            }

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLoginPass.Text == "Password")
            {
                txtLoginPass.Clear();
                txtLoginPass.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            attempt = 0;
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                loginTimer.Enabled = false;
                btnLogin.Enabled = true;
                txtLoginPass.Enabled = true;
                txtLoginUserName.Enabled = true;
                btnLogin.Text = "Login";
                txtLoginUserName.Focus();
            }
            else
            {
                btnLogin.Text = "log in" + count;
                count = count - 1;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signuppanel.Visible = true;
        }

        private void signupcreateaccbtn_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPass.Text;
            string cpassword = txtCheckPass.Text;

            //validation pattern
            string namePattern = @"^[a-zA-Z]{6,12}$";
            string passPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,16}$";
            string emailPattern = @"^[a-zA-Z0-9._%+]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(username)) //username null validation
            {
                MessageBox.Show("Please enter your Name!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            } 
            else if (string.IsNullOrEmpty(email)) //email null validation
            {
                MessageBox.Show("PLease enter your Email!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(password)) //password null validation
            {
                MessageBox.Show("PLease enter your Password!!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cpassword)) //check password null validation
            {
                MessageBox.Show("PLease enter your Re-password!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheckPass.Focus();
                return;
            }
            else if (!Regex.IsMatch(username, namePattern)) //username format validation
            {
                MessageBox.Show("At least 6 characters long & At most 12 characters long.", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            else if (!Regex.IsMatch(email, emailPattern)) //email format validation
            {
                MessageBox.Show("Unvalid Email","Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if (!Regex.IsMatch(password, passPattern)) //password format validation
            {
                MessageBox.Show("At least 8 characters long && at most 15 characters long. \n Contain at least one Uppercase letter. \n Contain at least one digit. \n Contain at least special one character.", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            else if (password != cpassword) // password & checkpassowrd match validation
            {
                MessageBox.Show("Password and Re-password doesn't match.", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheckPass.Focus();
            }
            else
            {
                MySqlConnection cn = Dataconnection.connect();
                MySqlCommand cmd = new MySqlCommand("insert into userdata(username,email,password,phone) values (@username,@email,@password,@phone)",cn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", int.Parse(phone));
                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    MessageBox.Show("Create Account Success!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Create Account Fail!", "Signup Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signuploginbtn_Click_1(object sender, EventArgs e)
        {
            signuppanel.Visible = false;
        }

        //phone textbox digit only
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = Dataconnection.connect();

            string username = txtLoginUserName.Text;
            string password = txtLoginPass.Text;
            string query = "select * from userdata where username = @username and password = @password";

            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                dataStore.uid = int.Parse(reader["uid"].ToString());
                BuyerHistory orderedBook = new BuyerHistory(dataStore);

                string type = reader["type"].ToString();
                if (type == "Admin")
                {
                    Dashbord ds = new Dashbord(dataStore);
                    ds.ShowDialog();
                    this.Hide();
                }
                else
                {
                    //for userDashboard             
                    reader.Close();

                    DynamicUCTest duc = new DynamicUCTest(dataStore);
                    this.Hide();
                    duc.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect. \nPlease try again later", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtLoginUserName.Clear();
                txtLoginPass.Clear();
                txtLoginUserName.Focus();
                attempt = attempt + 1;
                disable();
            }
        }
    }
}
