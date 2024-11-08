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
    public partial class LoginAdmin : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        Class1USER clscon = new Class1USER();
        public LoginAdmin()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == string.Empty || txtpassword.Text == string.Empty)
                {
                    MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new MySqlCommand("select * from admin where username = '" + txtusername.Text + "' && password = '" + txtpassword.Text + "'", cn);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("You are successfully Login");
                    new adminDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username and password");
                    txtusername.Clear();
                    txtpassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
