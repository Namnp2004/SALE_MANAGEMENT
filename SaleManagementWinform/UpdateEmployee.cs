using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SaleManagementWinform
{
    public partial class UpdateEmployee : Form
    {


        public UpdateEmployee(string code, string fullname, string position, string username, string password)
        {

            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Disable the maximize/restore button
            this.MaximizeBox = false;
            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbx_code.Text = code + "";
            tbx_name.Text = fullname + "";
            tbx_username.Text = username;
            tbx_position.Text = position;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }
        private void UpdateEmployeeInDatabase(string code, string fullname, string position, string username, string password)
        {
            string query = "UPDATE Employee SET name = @name, code = @code, " +
                "username = @username, position = @position, password = @password WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@name", fullname);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No Employee found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void DeleteEmployeeFromDatabase(string code)
        {
            string query = "UPDATE Employee SET active = 0 WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@code", code);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No Employee found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // Convert to hexadecimal
                }
                return builder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string code = tbx_code.Text;
            string fullname = tbx_name.Text;
            string position = tbx_position.Text.ToString().Trim();
            string username = tbx_username.Text.ToString().Trim();
            string password = HashPassword(tbx_password.Text.ToString().Trim());

            UpdateEmployeeInDatabase(code, fullname, position, username, password);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this Employee?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the product from the database
                DeleteEmployeeFromDatabase(tbx_code.Text.ToString());
                this.Close();
            }
        }
    }
}