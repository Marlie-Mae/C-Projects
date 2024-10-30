using System;
using System.Data;
using Microsoft.Data.SqlClient; // Use this if you're on .NET Core or later
using System.Windows.Forms;

namespace ProductForm
{
    public partial class Form1 : Form
    {
        private string currentProductId; // Track the current product ID
        private int currentIndex = -1; // To track the current index in a product list
        private DataTable productsTable; // To hold the list of products

        public Form1()
        {
            InitializeComponent();
            txtpid.Text = "PRD0001";
            LoadProducts(); // Load products on form load
        }

        private void LoadProducts()
        {
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    productsTable = new DataTable();
                    adapter.Fill(productsTable);
                }
            }

            currentIndex = -1;
            if (productsTable.Rows.Count > 0)
            {
                currentIndex = 0; // Start at the first product
                LoadProductDetails();
            }
        }

        private void LoadProductDetails()
        {
            if (currentIndex >= 0 && currentIndex < productsTable.Rows.Count)
            {
                DataRow row = productsTable.Rows[currentIndex];
                txtpid.Text = row["Product_ID"].ToString();
                txtpname.Text = row["Product_Name"].ToString();
                txtpdesc.Text = row["Product_Description"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpid.Text))
            {
                txtpid.Text = "PRD0001";
            }

            string productId = txtpid.Text;
            string productName = txtpname.Text;
            string productDescription = txtpdesc.Text;

            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products (Product_ID, Product_Name, Product_Description) VALUES (@Product_ID, @Product_Name, @Product_Description)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Product_ID", productId);
                    command.Parameters.AddWithValue("@Product_Name", productName);
                    command.Parameters.AddWithValue("@Product_Description", productDescription);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully.");
                        LoadProducts(); // Refresh the product list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (currentIndex < 0 || currentIndex >= productsTable.Rows.Count)
            {
                MessageBox.Show("No product selected to edit.");
                return;
            }

            string productId = txtpid.Text;
            string productName = txtpname.Text;
            string productDescription = txtpdesc.Text;

            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Products SET Product_Name = @Product_Name, Product_Description = @Product_Description WHERE Product_ID = @Product_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Product_ID", productId);
                    command.Parameters.AddWithValue("@Product_Name", productName);
                    command.Parameters.AddWithValue("@Product_Description", productDescription);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product updated successfully.");
                        LoadProducts(); // Refresh the product list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (currentIndex < productsTable.Rows.Count - 1)
            {
                currentIndex++;
                LoadProductDetails();
            }
            else
            {
                MessageBox.Show("You are at the last product.");
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                LoadProductDetails();
            }
            else
            {
                MessageBox.Show("You are at the first product.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string productId = txtpid.Text;

            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Products WHERE Product_ID = @Product_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Product_ID", productId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product deleted successfully.");
                        LoadProducts(); // Refresh the product list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txtpid.Clear();
            txtpname.Clear();
            txtpdesc.Clear();
            txtpid.Text = "PRD0001"; // Reset default Product ID value
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedOption = comboHistory.SelectedItem.ToString();

            // Based on the selected option, open the corresponding form
            switch (selectedOption)
            {
                case "Available Products":
                    Form2 availableProductsForm = new Form2();
                    availableProductsForm.Show(); // Show Form2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
