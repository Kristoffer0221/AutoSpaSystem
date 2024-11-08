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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            new customerClient().Show();
            this.Hide();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnServiceOrder_Click(object sender, EventArgs e)
        {
            new adminServiceOrder().Show();
            this.Hide();
        }

        private void btnCartype_Click(object sender, EventArgs e)
        {
            new adminBook().Show();
            this.Hide();
        }

        private void btnClient_Click_1(object sender, EventArgs e)
        {
            new adminClient().Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new UserList().Show();
            this.Hide();
        }

        private void btnServiceOrder_Click_1(object sender, EventArgs e)
        {
            new adminServiceOrder().Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new adminServices().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SalesReport().Show();
            this.Hide();
        }
    }
}
