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
    public partial class customerBook : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        Class1USER clscon = new Class1USER();
        public customerBook()
        {
            InitializeComponent();
            InitializeFormComponents();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadCustomers();
            LoadServiceTypes();
            LoadSizes();
            LoadTransactions();

            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            serviceCB.SelectedIndexChanged += serviceCB_SelectedIndexChanged;

          // dataGridViewTransactions = new DataGridView();
           //dataGridViewTransactions.Dock = DockStyle.Fill;
           //Controls.Add(dataGridViewTransactions);
        }
        private void InitializeFormComponents()
        {
            // Add this method in your form constructor or Load event to initialize components
            button1.Click += button1_Click; // Attach the event handler to the button
        }

        private void LoadCustomers()
        {
            string selectCustomersQuery = "SELECT accountID, username FROM customer";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectCustomersQuery, cn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                custNameCB.DataSource = dataTable;
                custNameCB.DisplayMember = "username";
                custNameCB.ValueMember = "accountID";
            }
        }
        private void LoadServiceTypes()
        {
            string selectServiceTypesQuery = "SELECT serviceType_id, service_name FROM servicetype";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectServiceTypesQuery, cn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                serviceCB.DataSource = dataTable;
                serviceCB.DisplayMember = "service_name";
                serviceCB.ValueMember = "serviceType_id";
            }
        }
        private void LoadSizes()
        {
            // Load sizes for the default or initially selected service type
            if (serviceCB.SelectedItem != null)
            {
                int serviceType_id = Convert.ToInt32(serviceCB.SelectedValue);
                LoadSizes(serviceType_id);
            }
        }
        private void LoadSizes(int serviceType_id)
        {
            string selectSizesQuery = "SELECT variant_id, size, price FROM service_variants WHERE serviceType_id = @serviceType_id";

            using (MySqlCommand command = new MySqlCommand(selectSizesQuery, cn))
            {
                command.Parameters.AddWithValue("@serviceType_id", serviceType_id);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    sizeComboBox.DataSource = dataTable;
                    sizeComboBox.DisplayMember = "size";
                    sizeComboBox.ValueMember = "price";
                }
            }
        }
        private void LoadTransactions()
        {
            // Fetch transaction details from the Transactions table
            string selectTransactionsQuery = "SELECT transactionID, username, service_name, size, price, transaction_date " +
                                         "FROM transactions " +
                                         "JOIN customer ON transactions.accountID = customer.accountID " +
                                          "JOIN service_variants ON transactions.variant_id = service_variants.variant_id " +
                                          "JOIN servicetype ON service_variants.serviceType_id = servicetype.serviceType_id ";


            using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectTransactionsQuery, cn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the data to the DataGridView
              //  dataGridViewTransactions.DataSource = dataTable;
            }
        }
        private void InsertTransaction(int accountID, int variant_id)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open(); // Open the connection if it's not already open
                }
                string sdate = dateTimebday.Value.ToString("yyyy-MM-dd");
                string insertTransactionQuery = "INSERT INTO transactions (accountID, variant_id, transaction_date) " +
                                        "VALUES (@accountID, @variant_id, @transaction_date)";

                using (MySqlCommand command = new MySqlCommand(insertTransactionQuery, cn))
                {
                    // Provide parameter values
                    command.Parameters.AddWithValue("@accountID", accountID);
                    command.Parameters.AddWithValue("@variant_id", variant_id);
                    command.Parameters.AddWithValue("@transaction_date", DateTime.Now);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Transaction inserted successfully.");
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

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeComboBox.SelectedItem != null)
            {
                decimal price = Convert.ToDecimal(sizeComboBox.SelectedValue);

                // Display the price in the textbox
                pricetb.Text = price.ToString("C");
            }
        }


        private void serviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceCB.SelectedItem != null)
            {
                // Get the selected service type and its associated ServiceTypeID from the combo box
                int serviceType_id = Convert.ToInt32(serviceCB.SelectedValue);

                // Load sizes and prices based on the selected service type
                LoadSizes(serviceType_id);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (custNameCB.SelectedItem != null && serviceCB.SelectedItem != null && sizeComboBox.SelectedItem != null)
            {
                int accountID = Convert.ToInt32(custNameCB.SelectedValue);
                int variant_id = Convert.ToInt32(serviceCB.SelectedValue);


                InsertTransaction(accountID, variant_id);

            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new customerDashboard().Show();
            this.Hide();
        }

        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void customerBook_Load(object sender, EventArgs e)
        {

        }
    }
}
