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
            MySqlConnection cn = Dataconnection.connect();
            MySqlDataReader reader = null;

            MySqlCommand cmd1 = new MySqlCommand("select * from rentbook", cn);
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], Convert.ToDateTime(reader[2]).ToString("dd-MM-yyyy"), Convert.ToDateTime(reader[3]).ToString("dd-MM-yyyy"), reader[4]);
            }            
            reader.Close();
        }
    }
}
