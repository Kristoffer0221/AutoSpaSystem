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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                try
                {

                    string myConnection =
                "datasource=localhost;database=registration;port=3306;username=root;password=;";
                    string query = "update account set accountid = '" + textBoxcustomerID.Text + "' , username = '" + textBoxusername.Text + "' , firstname = '"+ textBoxfname+"', password = '" + txtpassword.Text + "'";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    MySqlCommand cmd = new MySqlCommand(query, myConn);
                    MySqlDataReader reader;


                    try
                    {
                        myConn.Open();
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Data is UPDATED!!!");
                        myConn.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
