using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoSpaSystem
{
    public partial class UserList : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        Class1USER clscon = new Class1USER();
        public UserList()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecordsCustomer();
            LoadRecordsAdmin();
        }
        public void LoadRecordsCustomer()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from customer order by username,firstname,lastname", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }

            dr.Close();
            cn.Close();
        }
        public void LoadRecordsAdmin()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM admin", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }

            dr.Close();
            cn.Close();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            //your SQL syntax; check the manual that corresponds to your MariaDB server version for the right syntax to use near 'admin order by firstname' at line 1'


        }

        private void button6_Click(object sender, EventArgs e)
        {
            new adminDashboard().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new adminClient().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new adminServiceOrder().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new adminServices().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new adminBook().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserList().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new SalesReport().Show();
            this.Hide();
        }
    }
}