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
    public partial class adminServices : Form
    {
        public adminServices()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new adminDashboard().Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            new adminClient().Show();
            this.Hide();
        }

        private void btnServiceOrder_Click(object sender, EventArgs e)
        {
            new adminServiceOrder().Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new adminServices().Show();
            this.Hide();
        }

        private void btnCartype_Click(object sender, EventArgs e)
        {
            new adminBook().Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new UserList().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SalesReport().Show();
            this.Hide();
        }
    }
}
