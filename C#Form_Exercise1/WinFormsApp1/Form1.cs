using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Phil\Documents\testing.mdf;Integrated Security=True;Connect Timeout=30");
        private string? selectedStudentId = null;

        public Form1()
        {
            InitializeComponent();
            LoadData();

            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Prefer not to say");
        }

        private void button1_Click(object sender, EventArgs e) // Add
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmdGetMaxId = new SqlCommand("SELECT MAX(StudentID) FROM [dbo].[Table]", con);
                var maxIdResult = cmdGetMaxId.ExecuteScalar();
                string newStudentId;

                if (maxIdResult != DBNull.Value)
                {
                    string maxId = maxIdResult.ToString();
                    int nextIdNum = int.Parse(maxId.Substring(1)) + 1;
                    newStudentId = "S" + nextIdNum.ToString("D3");
                }
                else
                {
                    newStudentId = "S001";
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO [dbo].[Table] (StudentID, FName, LName, Phonenum, Address, Gender) VALUES (@id, @value1, @value2, @value3, @value4, @value5)";

                cmd.Parameters.AddWithValue("@id", newStudentId);
                cmd.Parameters.AddWithValue("@value1", textBox2.Text);
                cmd.Parameters.AddWithValue("@value2", textBox1.Text);
                cmd.Parameters.AddWithValue("@value3", textBox3.Text);
                cmd.Parameters.AddWithValue("@value4", textBox6.Text);
                cmd.Parameters.AddWithValue("@value5", comboBox1.SelectedItem?.ToString() ?? "");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record added successfully!");
                ClearFields();
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Delete
        {
            if (selectedStudentId == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM [dbo].[Table] WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully!");
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Update
        {
            if (selectedStudentId == null)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE [dbo].[Table] SET FName = @value1, LName = @value2, Phonenum = @value3, Address = @value4, Gender = @value5 WHERE StudentID = @id";

                cmd.Parameters.AddWithValue("@value1", textBox2.Text);
                cmd.Parameters.AddWithValue("@value2", textBox1.Text);
                cmd.Parameters.AddWithValue("@value3", textBox3.Text);
                cmd.Parameters.AddWithValue("@value4", textBox6.Text);
                cmd.Parameters.AddWithValue("@value5", comboBox1.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully!");
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void LoadData()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID, FName, LName, Phonenum, Address, Gender FROM [dbo].[Table]", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["LName"].Value?.ToString() ?? string.Empty; // Last Name
                textBox2.Text = row.Cells["FName"].Value?.ToString() ?? string.Empty; // First Name
                textBox3.Text = row.Cells["Phonenum"].Value?.ToString() ?? string.Empty; // Phone Number
                textBox6.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty; // Address
                comboBox1.SelectedItem = row.Cells["Gender"].Value?.ToString() ?? string.Empty; // Gender
                selectedStudentId = row.Cells["StudentID"].Value?.ToString(); // Store selected StudentID

                // Debug message to check the selected ID
                MessageBox.Show("Selected Student ID: " + selectedStudentId);
            }
        }


        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            selectedStudentId = null; // Reset selected ID
        }

        private void buttonClear_Click(object sender, EventArgs e) // Clear
        {
            ClearFields();
        }

        private void buttonSearch_Click(object sender, EventArgs e) // Search
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string searchTerm = textBox5.Text;
                SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID, FName, LName, Phonenum, Address, Gender FROM [dbo].[Table] WHERE FName LIKE @search OR LName LIKE @search", con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
