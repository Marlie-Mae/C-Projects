using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProductForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadProducts(); // Initial load of products
            this.Shown += Form2_Shown; // Reload data each time Form2 is shown
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

        private void Form2_Shown(object sender, EventArgs e)
        {
            LoadProducts(); // Reload products each time Form2 is shown
        }

        private void comboHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboHistory.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Product":
                    Form1 availableProductsForm = new Form1();
                    availableProductsForm.Show();
                    this.Hide();
                    break;

                case "Stock IN":
                    Form3 stockInForm = new Form3();
                    stockInForm.Show();
                    this.Hide();
                    break;

                case "Stock OUT":
                    Form4 stockOutForm = new Form4();
                    stockOutForm.Show();
                    this.Hide();
                    break;

                case "Product History":
                    Form5 productHistoryForm = new Form5();
                    productHistoryForm.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            Form3 stockInForm = new Form3();
            stockInForm.Show();
            this.Hide();
        }

        private void btnsout_Click(object sender, EventArgs e)
        {
            Form4 stockOutForm = new Form4();
            stockOutForm.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
