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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AutoSpaSystem
{
    public partial class RegistrationForm : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        Class1USER clscon = new Class1USER();
        public RegistrationForm()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (textBoxusername.Text == string.Empty || textBoxfname.Text == string.Empty || textBoxlname.Text == string.Empty || textBoxaddress.Text == string.Empty || textBoxphone.Text == string.Empty || textBoxpassword.Text == string.Empty)
                {
                    MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into customer (username,firstname,lastname,address,phone, password) " +
                        "values('" + textBoxusername.Text + "', '" + textBoxfname.Text + "', " +
                        " '" + textBoxlname.Text + "','" + textBoxaddress.Text + "','" + textBoxphone.Text + "','" + textBoxpassword.Text + "')", cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("DATA ADDED!");
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("WARNING!");
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide(); 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
