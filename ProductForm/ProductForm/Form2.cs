using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Use this if you're on .NET Core or later

namespace ProductForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadProducts(); // Load products when the form initializes
        }

        private void LoadProducts()
        {
            // Connection string to connect to your database
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to select all products from the Products table
                string query = "SELECT * FROM Products";

                // Using SqlDataAdapter to fill a DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable productsTable = new DataTable();
                    adapter.Fill(productsTable); // Fill the DataTable with data
                    dataGridView1.DataSource = productsTable; // Bind the DataTable to the DataGridView
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method can be used to handle cell clicks if needed
        }

        private void comboHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedOption = comboHistory.SelectedItem.ToString();

            // Based on the selected option, open the corresponding form
            switch (selectedOption)
            {
                case "Product":
                    Form1 availableProductsForm = new Form1();
                    availableProductsForm.Show(); // Show Form1
                    this.Hide(); // Hide the current form (optional)
                    break;

                case "Stock IN":
                    Form3 stockInForm = new Form3();
                    stockInForm.Show(); // Show Form3
                    this.Hide(); // Hide the current form (optional)
                    break;

                case "Stock OUT":
                    Form4 stockOutForm = new Form4();
                    stockOutForm.Show(); // Show Form4
                    this.Hide(); // Hide the current form (optional)
                    break;

                case "Product History":
                    Form5 productHistoryForm = new Form5();
                    productHistoryForm.Show(); // Show Form5
                    this.Hide(); // Hide the current form (optional)
                    break;

                default:
                    break;
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            // Navigate to Form3 (Stock IN)
            Form3 stockInForm = new Form3();
            stockInForm.Show(); // Show the Stock IN form
            this.Hide(); // Optionally hide the current form
        }

        private void btnsout_Click(object sender, EventArgs e)
        {
            // Navigate to Form4 (Stock OUT)
            Form4 stockOutForm = new Form4();
            stockOutForm.Show(); // Show the Stock OUT form
            this.Hide(); // Optionally hide the current form
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

    }
}
