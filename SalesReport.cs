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
    public partial class SalesReport : Form
    {
        MySqlConnection cn;
        
        MySqlCommand cm;
        MySqlDataReader dr;
        Class1USER clscon = new Class1USER();
        public SalesReport()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadTransactions();

            dataGridViewtansactions = new DataGridView();
            dataGridViewtansactions.Dock = DockStyle.Fill;
            Controls.Add(dataGridViewtansactions);


        }
        private void LoadTransactions()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open(); // Open the connection if it's not already open
                }

                string selectTransactionsQuery = "SELECT transactionID, username, service_name, size, price, transaction_date " +
                                                 "FROM transactions " +
                                                 "JOIN customer ON transactions.accountID = customer.accountID " +
                                                 "JOIN service_variants ON transactions.variant_id = service_variants.variant_id " +
                                                 "JOIN servicetype ON service_variants.serviceType_id = servicetype.serviceType_id";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectTransactionsQuery, cn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridViewtansactions.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}");
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        private void InsertTransaction(int accountID, int variant_id)
        {
            try
            {
                // ... (your existing code)

                // After successful insertion, refresh the transactions in the DataGridView
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting transaction: {ex.Message}");
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new adminDashboard().Show();
            this.Hide();
        }

        private void dataGridViewTansactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
