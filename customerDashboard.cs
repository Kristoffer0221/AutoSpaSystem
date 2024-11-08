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
    public partial class customerDashboard : Form
    {
        public customerDashboard()
        {
            InitializeComponent();
        }

        private void btnCartype_Click(object sender, EventArgs e)
        {
            new customerBook().Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            new customerClient().Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new customerServices().Show();
            this.Hide();
        }
    }
}
