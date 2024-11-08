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

namespace AutoSpaSystem
{
    public partial class customerClient : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        Class1USER clscon = new Class1USER();

      

        public customerClient()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from customer order by username,firstname,lastname", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }

            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new adminDashboard().Show();
            this.Hide();
        }

        private void btnServiceOrder_Click(object sender, EventArgs e)
        {
            new adminServiceOrder().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
           

        
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            new customerDashboard().Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            new customerClient().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new customerServices().Show();
            this.Hide();
        }

        private void btnCartype_Click(object sender, EventArgs e)
        {

        }
    }
}
